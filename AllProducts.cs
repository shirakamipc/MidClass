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
	public partial class AllProducts : Form
	{
		public AllProducts()
		{
			InitializeComponent();
		}

		DBAccess dBAccess = new DBAccess();
		DataTable dtProducts = new DataTable();
		private void AllProducts_Load(object sender, EventArgs e)
		{
			string query = "select * from EndClass.dbo.Users";
			dBAccess.readDatathroughAdapter(query, dtProducts);
			productsGridView.DataSource = dtProducts;

			for (int i = 0; i <= productsGridView.Columns.Count - 1; i++)
			{
				productsGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}

			dBAccess.closeConn();
		}
	}
}
