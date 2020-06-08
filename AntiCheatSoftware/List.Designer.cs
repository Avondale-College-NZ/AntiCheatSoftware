namespace AntiCheatSoftware
{
    partial class List
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
            this.label1 = new System.Windows.Forms.Label();
            this.listProcess = new System.Windows.Forms.ListView();
            this.Names = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Active Processes:";
            // 
            // listProcess
            // 
            this.listProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Names});
            this.listProcess.GridLines = true;
            this.listProcess.HideSelection = false;
            this.listProcess.Location = new System.Drawing.Point(15, 35);
            this.listProcess.Name = "listProcess";
            this.listProcess.Size = new System.Drawing.Size(369, 358);
            this.listProcess.TabIndex = 4;
            this.listProcess.UseCompatibleStateImageBehavior = false;
            this.listProcess.View = System.Windows.Forms.View.Details;
            this.listProcess.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listProcess.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listProcess_MouseDoubleClick);
            // 
            // Names
            // 
            this.Names.Text = "Names of Processes";
            this.Names.Width = 355;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AntiCheatSoftware.Properties.Resources.Refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(358, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 27);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(396, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listProcess);
            this.Controls.Add(this.label1);
            this.Name = "List";
            this.Text = "List Of Processes";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Names;
        public System.Windows.Forms.ListView listProcess;
        private System.Windows.Forms.Button button1;
    }
}