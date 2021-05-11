namespace APTask
{
    partial class TodoManager
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
            this.delete1 = new System.Windows.Forms.Button();
            this.clear1 = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
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
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
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
            this.taskNameBox.Location = new System.Drawing.Point(615, 12);
            this.taskNameBox.Name = "taskNameBox";
            this.taskNameBox.Size = new System.Drawing.Size(143, 20);
            this.taskNameBox.TabIndex = 2;
            this.taskNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.taskNameBox_KeyPress);
            // 
            // delete1
            // 
            this.delete1.Location = new System.Drawing.Point(649, 67);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(75, 23);
            this.delete1.TabIndex = 3;
            this.delete1.Text = "Delete";
            this.delete1.UseVisualStyleBackColor = true;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // clear1
            // 
            this.clear1.Location = new System.Drawing.Point(649, 97);
            this.clear1.Name = "clear1";
            this.clear1.Size = new System.Drawing.Size(75, 23);
            this.clear1.TabIndex = 4;
            this.clear1.Text = "Clear";
            this.clear1.UseVisualStyleBackColor = true;
            this.clear1.Click += new System.EventHandler(this.clear1_Click);
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(649, 126);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 5;
            this.import.Text = "Import";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(649, 155);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 6;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // TodoManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 446);
            this.Controls.Add(this.export);
            this.Controls.Add(this.import);
            this.Controls.Add(this.clear1);
            this.Controls.Add(this.delete1);
            this.Controls.Add(this.taskNameBox);
            this.Controls.Add(this.submitTaskName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TodoManager";
            this.Text = "To-Do Manager";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button submitTaskName;
        private System.Windows.Forms.TextBox taskNameBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button delete1;
        private System.Windows.Forms.Button clear1;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button export;
    }
}

