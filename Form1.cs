using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace APTask
{
    public partial class TodoManager : Form
    {
        string Text = "";
#if RELEASE 
        string path = System.IO.Directory.GetCurrentDirectory() + @"\Tasks.json";
#else
        string path = System.IO.Directory.GetCurrentDirectory() + @"\Tasks.json";
#endif
        List<Task> Tasks = new List<Task>();

        public TodoManager()
        {
            InitializeComponent();
            this.Text = "To-Do Manager";
        }

        private void submitTaskName_Click(object sender, EventArgs e)
        {
            Text = taskNameBox.Text;
            if (String.IsNullOrEmpty(Text)) { return; }
            Task _task = new Task(Text, DateTime.Now, false);
            Tasks.Add(_task);
            checkedListBox1.Items.Add(_task.Created + ": " + _task.TaskName);
        }

        private void delete1_Click(object sender, EventArgs e)
        {
            //From https://stackoverflow.com/questions/37748051/how-to-retrieve-texts-for-checkeditems-in-checkedlistbox
            var tasks = checkedListBox1.CheckedItems.Cast<object>();
            var text = tasks.Select(x => checkedListBox1.GetItemText(x));
            //checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[0]);
            for(int i = 0; i <= checkedListBox1.CheckedItems.Count; i++)
            {
                //MessageBox.Show("I: " + i.ToString() + "CheckedText: " + checkedListBox1.CheckedItems[0].ToString());
                checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[0]);
            }
        }

        private void clear1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
        }

        private void import_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            StreamReader fs = new StreamReader(path.ToString());
            Tasks = JsonConvert.DeserializeObject<List<Task>>(fs.ReadToEnd());
            fs.Close();
            foreach(Task x in Tasks)
            {
                checkedListBox1.Items.Add(x.Created + ": " + x.TaskName, x.Completed);
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            //StreamWriter fs = new StreamWriter(path.ToString(), );
            try
            {
                string json = JsonConvert.SerializeObject(Tasks);

                File.WriteAllText(path, json);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Task _task = new Task(i.ToString(), DateTime.Now, false);
                Tasks.Add(_task);
                checkedListBox1.Items.Add(_task.Created + ": " + _task.TaskName);
            }

        }

        private void taskNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                submitTaskName_Click(new object(), new EventArgs());
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Tasks[e.Index].Completed = true;
        }
    }
}
