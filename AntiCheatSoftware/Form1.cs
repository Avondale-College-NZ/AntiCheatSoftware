using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AntiCheatSoftware
{
    public partial class AntiCheat : Form
    {
        private Button btnScan;
        private Label lblHead;
        private ProgressBar progressBar1;
        private Label label1;
        private Label lblStatus;
        private LinkLabel lblHelp;
        private CheckBox checkBox1;
        private ToolTip toolTip;
        private IContainer components;
        public TextBox txtInput;


        public AntiCheat()
        {
            InitializeComponent();

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnScan = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblHelp = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(355, 152);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Terminate";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(161, 100);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(65, 24);
            this.lblHead.TabIndex = 1;
            this.lblHead.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(232, 100);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(140, 24);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Ready To Scan";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.HotPink;
            this.progressBar1.Location = new System.Drawing.Point(96, 181);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(334, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Anti Cheat Software";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(96, 154);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(253, 20);
            this.txtInput.TabIndex = 5;
            this.txtInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(93, 219);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(29, 13);
            this.lblHelp.TabIndex = 6;
            this.lblHelp.TabStop = true;
            this.lblHelp.Text = "Help";
            this.lblHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHelp_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(357, 215);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Automatic";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.MouseHover += new System.EventHandler(this.checkBox1_MouseHover);
            // 
            // AntiCheat
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(558, 299);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnScan);
            this.Name = "AntiCheat";
            this.Text = "Anti Cheat Software";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            //Clicked button
            lblStatus.Text = "Scanning";
            lblStatus.ForeColor = System.Drawing.Color.Red;
            progressBar1.Value = 100;

            //Detects the input in the textbox, the "process" will be declared as an array
            Process.GetProcessesByName(txtInput.Text);
            Process[] findProcess = Process.GetProcessesByName(txtInput.Text);

            //Logical statements
            if (findProcess.Length == 0)
            {
                MessageBox.Show("Process Not Found");
            }

            else
            {
                lblStatus.Text = "Scanning";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                DialogResult killProcess = MessageBox.Show("Process Found\nWould you like to terminate the process: "+txtInput.Text+"?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Error);

                if (killProcess == DialogResult.Yes)
                {
                    foreach (var p in Process.GetProcessesByName(txtInput.Text))
                    {
                        p.Kill();
                    }
                }
            }

            lblStatus.Text = "Ready To Scan";
            lblStatus.ForeColor = System.Drawing.Color.Green;
            txtInput.Text = "";
            progressBar1.Value = 0;
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            //Haven't clicked button
            lblStatus.Text = "Ready To Scan";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //Display Progress
            progressBar1.Visible = true;

          
        }

        private void Process_Exited(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Opens the Help form
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.checkBox1,"When enabled, the program will continuously check for the process entered in the textbox.\nOnce the process has been detected it will automatically close.");
        }

        bool detected = false;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Process.GetProcessesByName(txtInput.Text);
            Process[] findProcess = Process.GetProcessesByName(txtInput.Text);

            while (detected == false)
            {

                if (findProcess.Length > 0)
                {
                    lblStatus.Text = "Scanning";
                    lblStatus.ForeColor = System.Drawing.Color.Red;

                    DialogResult killProcess = MessageBox.Show("The process " + txtInput.Text + " has been detected and will now be terminated.", "Anti Cheat Software", MessageBoxButtons.OK);

                        foreach (var p in Process.GetProcessesByName(txtInput.Text))
                        {
                        //Terminate the program and sets detected to true to stop the while loop
                            p.Kill();
                            detected = true;
                        }

                        if (killProcess == DialogResult.OK)
                    {
                        //Once OK has been pressed, detected will be set back to false so the automatic feature can be used again
                        txtInput.Text = "";
                        detected = false;
                    }
                }

                else
                {

                }

                lblStatus.Text = "Ready To Scan";
                lblStatus.ForeColor = System.Drawing.Color.Green;
                txtInput.Text = "";
                progressBar1.Value = 0;
            }
        }
    }
}
