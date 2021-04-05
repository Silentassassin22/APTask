namespace APTask
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.submitTaskName = new System.Windows.Forms.Button();
            this.taskNameBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkedListBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(556, 426);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(553, 424);
            this.checkedListBox1.TabIndex = 0;
            // 
            // submitTaskName
            // 
            this.submitTaskName.Location = new System.Drawing.Point(649, 38);
            this.submitTaskName.Name = "submitTaskName";
            this.submitTaskName.Size = new System.Drawing.Size(75, 23);
            this.submitTaskName.TabIndex = 1;
            this.submitTaskName.Text = "Submit";
            this.submitTaskName.UseVisualStyleBackColor = true;
            this.submitTaskName.Click += new System.EventHandler(this.submitTaskName_Click);
            // 
            // taskNameBox
            // 
            this.taskNameBox.Location = new System.Drawing.Point(611, 12);
            this.taskNameBox.Name = "taskNameBox";
            this.taskNameBox.Size = new System.Drawing.Size(143, 20);
            this.taskNameBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taskNameBox);
            this.Controls.Add(this.submitTaskName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button submitTaskName;
        private System.Windows.Forms.TextBox taskNameBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

