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
            Task _task = new Task(Text, new DateTime(), false);
            checkedListBox1.Items.Add(_task.TaskName);

        }
    }
}
