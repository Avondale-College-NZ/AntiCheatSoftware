using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AntiCheatSoftware
{
    
    public partial class Timeline : Form
    {
        public Timeline()
        {
            InitializeComponent();
        }

        string conString = @"Data Source = tpisql01.avcol.school.nz; Initial Catalog = ProcessTimeline; Integrated Security = True;";

        void FillList()
        {
            //Open connection to database, connect to query
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Timeline", sqlCon);
                SqlDataReader dr;
                sqlCmd.CommandText = "select * from tblTimeline";
                sqlCmd.Connection = sqlCon;
                dr = sqlCmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[1].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    item.SubItems.Add(dr[3].ToString());

                    listTimeline.Items.Add(item);
                }



            }

        }

        private void listTimeline_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Timeline_Load(object sender, EventArgs e)
        {
            FillList();
        }

        private void Timeline_FormClosed(object sender, FormClosedEventArgs e)
        {
            AntiCheat.toggleHistory -= 1;
        }
    }
}
