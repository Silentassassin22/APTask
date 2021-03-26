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
            MessageBox.Show(Text);

        }
    }
}
