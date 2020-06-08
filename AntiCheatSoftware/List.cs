using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiCheatSoftware
{
    public partial class List : Form
    {


        public List()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Upon loading it will initiate the loadProcesslist method.
            loadProcesslist();
        }

            //An array 
            Process[] processes = Process.GetProcesses();


        private void loadProcesslist()
        {
            listProcess.Items.Clear();
            //Checks all the active process names and adds them to the "listProcess" listview
            foreach (Process process in processes)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.Tag = processes;
                listProcess.Items.Add(item);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string selectedItem;

        public void listProcess_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*Once an item is double clicked, it'll hide the task form the taskbar*/

            if (listProcess.SelectedItems.Count > 0)
            {
                var item = listProcess.SelectedItems[0];
                selectedItem = item.Text;

                AntiCheat form1 = new AntiCheat();
                form1.Show();
                form1.txtInput.Text = selectedItem;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadProcesslist();
        }
    }
}
