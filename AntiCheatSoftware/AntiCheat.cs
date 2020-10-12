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
using System.Data.SqlClient;

namespace AntiCheatSoftware
{
    public partial class AntiCheat : Form
    {
        private Button btnTerminate;
        private Label lblHead;
        private ProgressBar scanProgress;
        private Label lblTitle;
        private Label lblStatus;
        private CheckBox chkStealth;
        private ToolTip toolTip;
        private IContainer components;
        private MenuStrip menuStrip;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStrip;
        private ToolStripMenuItem timelineToolStripMenuItem;
        private NotifyIcon antiCheatNotifyIcon;
        private ContextMenuStrip notifyIconMenuStrip;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Timer stealthTimer;
        private ListView listProcess;
        private TextBox txtSearch;
        private Label lblSearch;
        private Label label2;
        private ColumnHeader columnHeader1;
        private Button btnSearch;
        public TextBox txtInput;


        public AntiCheat()
        {
            InitializeComponent();
            loadProcessList();
        }

        //All this is automatically generated, it is the code for the Design
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.scanProgress = new System.Windows.Forms.ProgressBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.chkStealth = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.timelineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiCheatNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stealthTimer = new System.Windows.Forms.Timer(this.components);
            this.listProcess = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.notifyIconMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTerminate
            // 
            this.btnTerminate.Location = new System.Drawing.Point(317, 114);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(75, 23);
            this.btnTerminate.TabIndex = 0;
            this.btnTerminate.Text = "Terminate";
            this.btnTerminate.UseVisualStyleBackColor = true;
            this.btnTerminate.Click += new System.EventHandler(this.btnTerminate_Click);
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(54, 76);
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
            this.lblStatus.Location = new System.Drawing.Point(125, 76);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(140, 24);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Ready To Scan";
            // 
            // scanProgress
            // 
            this.scanProgress.ForeColor = System.Drawing.Color.HotPink;
            this.scanProgress.Location = new System.Drawing.Point(58, 140);
            this.scanProgress.Name = "scanProgress";
            this.scanProgress.Size = new System.Drawing.Size(334, 23);
            this.scanProgress.TabIndex = 3;
            this.scanProgress.Click += new System.EventHandler(this.scanProgress_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(52, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 31);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Anti Cheat Software";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(58, 114);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(253, 20);
            this.txtInput.TabIndex = 5;
            // 
            // chkStealth
            // 
            this.chkStealth.AutoSize = true;
            this.chkStealth.Location = new System.Drawing.Point(303, 169);
            this.chkStealth.Name = "chkStealth";
            this.chkStealth.Size = new System.Drawing.Size(89, 17);
            this.chkStealth.TabIndex = 7;
            this.chkStealth.Text = "Stealth Mode";
            this.chkStealth.UseVisualStyleBackColor = true;
            this.chkStealth.CheckedChanged += new System.EventHandler(this.chkStealth_CheckedChanged);
            this.chkStealth.MouseHover += new System.EventHandler(this.chkStealth_MouseHover);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timelineToolStripMenuItem,
            this.helpToolStrip,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(454, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // timelineToolStripMenuItem
            // 
            this.timelineToolStripMenuItem.Name = "timelineToolStripMenuItem";
            this.timelineToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.timelineToolStripMenuItem.Text = "Timeline";
            this.timelineToolStripMenuItem.Click += new System.EventHandler(this.timelineToolStripMenuItem_Click);
            // 
            // helpToolStrip
            // 
            this.helpToolStrip.Name = "helpToolStrip";
            this.helpToolStrip.Size = new System.Drawing.Size(44, 20);
            this.helpToolStrip.Text = "Help";
            this.helpToolStrip.Click += new System.EventHandler(this.helpToolStrip_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // antiCheatNotifyIcon
            // 
            this.antiCheatNotifyIcon.BalloonTipText = "The software will now run until you stop it or until the specified process is fou" +
    "nd";
            this.antiCheatNotifyIcon.BalloonTipTitle = "Automatic Mode";
            this.antiCheatNotifyIcon.ContextMenuStrip = this.notifyIconMenuStrip;
            this.antiCheatNotifyIcon.Text = "Anti Cheat Software";
            // 
            // notifyIconMenuStrip
            // 
            this.notifyIconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.notifyIconMenuStrip.Name = "contextMenuStrip1";
            this.notifyIconMenuStrip.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // stealthTimer
            // 
            this.stealthTimer.Tick += new System.EventHandler(this.stealthTimer_Tick);
            // 
            // listProcess
            // 
            this.listProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listProcess.GridLines = true;
            this.listProcess.HideSelection = false;
            this.listProcess.Location = new System.Drawing.Point(55, 221);
            this.listProcess.Name = "listProcess";
            this.listProcess.Size = new System.Drawing.Size(334, 366);
            this.listProcess.TabIndex = 9;
            this.listProcess.UseCompatibleStateImageBehavior = false;
            this.listProcess.View = System.Windows.Forms.View.Details;
            this.listProcess.SelectedIndexChanged += new System.EventHandler(this.listProcess_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Process Name";
            this.columnHeader1.Width = 330;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(140, 600);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 20);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(52, 603);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(79, 13);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Process Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "List of active processes:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(330, 597);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // AntiCheat
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(454, 659);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listProcess);
            this.Controls.Add(this.chkStealth);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.scanProgress);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnTerminate);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "AntiCheat";
            this.Text = "Anti Cheat Software";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.notifyIconMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //Public variables
        public static bool openHelp = false;
        public static bool openTimeline = false;
        public string selectedItem;

        //Private variables
        bool stealth = false;
        string connectionString = @"Data Source = tpisql01.avcol.school.nz; Initial Catalog = ProcessTimeline; Integrated Security = True;";

        //Methods

        //Status Change
        private void StatusScan()
        {
            lblStatus.Text = "Scanning";
            lblStatus.ForeColor = System.Drawing.Color.Red;
            scanProgress.Value = 100;
        }

        private void StatusReady()
        {
            lblStatus.Text = "Ready To Scan";
            lblStatus.ForeColor = System.Drawing.Color.Green;
            scanProgress.Value = 0;
            txtInput.Text = "";
            //Reset stealth mode
            stealthTimer.Stop();
            stealth = false;
            chkStealth.Checked = false;
            this.Show();
            antiCheatNotifyIcon.Visible = false;
        }

        /*These limit classes are here to prevent mutliple copies of the form from being opened
         Upon opening the tabs, the methods are executed*/

        private void LimitHelp()
        {
            if (openHelp == false)
            {
                openHelp = true;
                Help help = new Help();
                help.Show();
            }
        }

        private void LimitTimeline()
        {
            if (openTimeline == false)
            {
                openTimeline = true;
                Timeline timeline = new Timeline();
                timeline.Show();
            }
        }

        /*This method will see how the specified process was terminated and will add the process name, time closed and method closed to
         the database*/
        private void AddData()
        {
            //Adds the date & time, process name and method of closing into the database(in connectionString)
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                //First we open the connection
                sqlCon.Open();
                //SqlCommand helps us execute commands from here to the database
                SqlCommand sqlCmd = new SqlCommand("Timeline", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ProcessName", txtInput.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@DateTime", DateTime.Now.ToLocalTime());
                if (stealth == true)
                {
                    sqlCmd.Parameters.AddWithValue("@MethodClose", "Stealth");
                }

                else
                {
                    sqlCmd.Parameters.AddWithValue("@MethodClose", "Manual");
                }
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Added to database");
            }
        }


        /*It will run in the background and will look for the specified process until it is found. 
          The user can also restart the program or go to the notify icon on the system tray to reveal the form*/
        private void StealthMode()
        {
            if (chkStealth.Checked == true && txtInput.Text != "")
            {
                this.Hide();
                antiCheatNotifyIcon.Visible = true;

                Process.GetProcessesByName(txtInput.Text);
                Process[] process = Process.GetProcessesByName(txtInput.Text);

                if (process.Length != 0)
                {
                    stealth = true;

                    foreach (var p in Process.GetProcessesByName(txtInput.Text))
                    {
                        //When it's found, it will kill the process and unveil the form.
                        p.Kill();
                        AddData();
                        StatusReady();
                    }

                }
            }

        }

        private void loadProcessList()
        {
            Process[] processes = Process.GetProcesses();
            listProcess.Items.Clear();
            //Loops through all the active process names and adds them to the "listProcess" listview
            foreach (Process process in processes)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.Tag = processes;
                listProcess.Items.Add(item);
            }

        }

        private void searchProcess()
        {

            //See if the text in the textbox matches any of the items in the viewlist
            if (txtSearch.Text != "")
            {
                //The viewlist will be filtered through a foreach loop
                foreach (ListViewItem item in listProcess.Items)
                {
                    if (!item.ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        listProcess.Items.Remove(item);
                    }
                }
            }

            else if (txtSearch.Text == "")
            {
                //Repopulates the listview, undoing the search filter
                loadProcessList();
            }

        }
        //
        //Events
        //
        private void btnTerminate_Click(object sender, EventArgs e)
        {
            //Detects the input (the process) in the textbox 
            Process.GetProcessesByName(txtInput.Text);
            Process[] process = Process.GetProcessesByName(txtInput.Text);
            StatusScan();

            if (process.Length == 0)
            {
                MessageBox.Show("Process Not Found");

            }
            else
            {
                DialogResult killProcess = MessageBox.Show("Process Found\n" +
                    "Would you like to terminate the process: " + txtInput.Text + "?", "Confirm"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (killProcess == DialogResult.Yes)
                {
                    foreach (var p in Process.GetProcessesByName(txtInput.Text))
                    {
                        p.Kill();
                        AddData();
                    }
                }
            }
            txtInput.Text = "";
            StatusReady();

        }

        private void scanProgress_Click(object sender, EventArgs e)
        {
            scanProgress.Visible = true;
        }

        private void chkStealth_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.chkStealth, "Enabling will make the Anti Cheat " +
                "close the specified process as soon as it opens");
        }

        //Toggle on/off "Automatic" Mode
        private void chkStealth_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStealth.Checked)
            {
                stealthTimer.Start();
            }
        }

        private void stealthTimer_Tick(object sender, EventArgs e)
        {
            StealthMode();
        }

        //Tabs on the menu strip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStrip_Click(object sender, EventArgs e)
        {
            LimitHelp();
        }

        private void timelineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimitTimeline();
        }

        //Tabs on the notify icon menu strip
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            StatusReady();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Once a process in the listProcess listview is selected, the name of the process
             will appear in the txtInput textbox*/

            if (listProcess.SelectedItems.Count > 0)
            {
                var item = listProcess.SelectedItems[0];
                selectedItem = item.Text;

                txtInput.Text = selectedItem;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //When the search button is pressed, look for the searched item
            searchProcess();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                loadProcessList();
            }
        }
    }
}