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

        public string selectedItem;
        //An array 
        Process[] processes = Process.GetProcesses();

        private void Form2_Load(object sender, EventArgs e)
        {
            //Upon loading it will initiate the loadProcesslist method.
            loadProcessList();
        }

        private void searchProcess()
        {
            //See if the text in the textbox matches any of the items in the viewlist
            if (txtProcess.Text != "")
            {
                System.Collections.IList list = listProcess.Items;
                for(int i = 0; i < list.Count; i++)
                {
                    ListViewItem item = (ListViewItem)list[i];
                    if (item.Text.Contains(txtProcess.Text.ToLower()))
                    {
                        
                    }

                    else
                    {
                        listProcess.Items.Remove(item);
                    }
                }
            }
           
        }

        private void loadProcessList()
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
            loadProcessList();
        }

        private void List_FormClosed(object sender, FormClosedEventArgs e)
        {
            AntiCheat.toggleList -= 1;
        }

        private void txtProcess_TextChanged(object sender, EventArgs e)
        {
            searchProcess();
        }
    }
}