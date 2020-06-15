namespace AntiCheatSoftware
{
    partial class Timeline
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
            this.listTimeline = new System.Windows.Forms.ListView();
            this.ProcessNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateClose = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MethodClose = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listTimeline
            // 
            this.listTimeline.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessNumber,
            this.DateClose,
            this.ProcessName,
            this.MethodClose});
            this.listTimeline.GridLines = true;
            this.listTimeline.HideSelection = false;
            this.listTimeline.Location = new System.Drawing.Point(12, 12);
            this.listTimeline.Name = "listTimeline";
            this.listTimeline.Size = new System.Drawing.Size(430, 481);
            this.listTimeline.TabIndex = 0;
            this.listTimeline.UseCompatibleStateImageBehavior = false;
            this.listTimeline.View = System.Windows.Forms.View.Details;
            this.listTimeline.SelectedIndexChanged += new System.EventHandler(this.listTimeline_SelectedIndexChanged);
            // 
            // ProcessNumber
            // 
            this.ProcessNumber.Text = "Process";
            this.ProcessNumber.Width = 50;
            // 
            // DateClose
            // 
            this.DateClose.Text = "Date Closed";
            this.DateClose.Width = 161;
            // 
            // ProcessName
            // 
            this.ProcessName.Text = "Name";
            this.ProcessName.Width = 131;
            // 
            // MethodClose
            // 
            this.MethodClose.Text = "Method";
            this.MethodClose.Width = 71;
            // 
            // Timeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 505);
            this.Controls.Add(this.listTimeline);
            this.Name = "Timeline";
            this.Text = "Timeline";
            this.Load += new System.EventHandler(this.Timeline_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listTimeline;
        private System.Windows.Forms.ColumnHeader ProcessNumber;
        private System.Windows.Forms.ColumnHeader DateClose;
        private System.Windows.Forms.ColumnHeader ProcessName;
        private System.Windows.Forms.ColumnHeader MethodClose;
    }
}