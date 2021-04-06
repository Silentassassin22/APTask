using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APTask
{
    public partial class Form1 : Form
    {

        List<Task> Tasks = new List<Task>();

        public Form1()
        {
            InitializeComponent();
        }

        private void submitTaskName_Click(object sender, EventArgs e)
        {
            Text = taskNameBox.Text;
            Task _task = new Task(Text, DateTime.Now, false);
            checkedListBox1.Items.Add(_task.Created + ": " + _task.TaskName);
        }

        private void delete1_Click(object sender, EventArgs e)
        {
            var tasks = checkedListBox1.CheckedItems.Cast<object>();
            var text = tasks.Select(x => checkedListBox1.GetItemText(x));
            MessageBox.Show(Convert.ToString(tasks.Count()));
            checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[0]);
            for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[0]);
            }
        }
    }
}
