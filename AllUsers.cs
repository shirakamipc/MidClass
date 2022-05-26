using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidClass
{
	public partial class AllUsers : Form
	{
		public AllUsers()
		{
			InitializeComponent();
			UpdateUsers.Click += new EventHandler(UpdateUsers_Click);
		}

		private void UpdateUsers_Click(object sender, EventArgs e)
		{
			//throw new NotImplementedException();
		}

		

		DBAccess dBAccess = new DBAccess();

		DataTable dtUsers = new DataTable();

		string query;
		
		int index = 1;
		
		private void AllUsers_Load(object sender, EventArgs e)
		{
			
			query = "use EndClass;select * from dbo.Users ";//where UId > " + (((index-1)*5).ToString()) + "and UId <=" + ((index * 5).ToString());
			dBAccess.readDatathroughAdapter(query, dtUsers);
			dataGridView1.DataSource = dtUsers;
			
			for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
			{
				dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			}

			dBAccess.closeConn();
		}

	}
}
