using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MidClass
{
	public partial class AllUsers : Form
	{
		public AllUsers()
		{
			InitializeComponent();
		}


		

		DBAccess dBAccess = new DBAccess();

		public static DataTable dtUsers = new DataTable();
		
		private void AllUsers_Load(object sender, EventArgs e)
		{
			
			string query = "select * from EndClass.dbo.Users";//where UId > " + (((index-1)*5).ToString()) + "and UId <=" + ((index * 5).ToString());
			dBAccess.readDatathroughAdapter(query, dtUsers);
			dataGridView1.DataSource = dtUsers;
			
			for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
			{
				dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}

			dBAccess.closeConn();
		}

		private void UpdateUsers_Click_1(object sender, EventArgs e)
		{
			string query = "select * from EndClass.dbo.Users";
			int changes = dBAccess.executeDataAdapter(dtUsers, query);
			MessageBox.Show("There is " + changes +" changes");
		}


	}
}
