using System;
using System.IO;
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
	public partial class Allproducts2 : Form
	{
		public Allproducts2()
		{
			InitializeComponent();
		}
		#region Virables
		DBAccess dBAccess = new DBAccess();
		public static DataTable dtProducts = new DataTable();
		String query;
		#endregion

		private void Allproducts2_Load(object sender, EventArgs e)
		{
			query = "select * from EndClass.dbo.Product";
			dBAccess.readDatathroughAdapter(query, dtProducts);
			productsGrid.DataSource = dtProducts;
			productsGrid.Columns[4].Visible = true;
			for (int i = 0; i <= productsGrid.Columns.Count - 1; i++)
			{
				productsGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}

			dBAccess.closeConn();
		}

		//this is in fact update products
		private void UpdateUsers_Click(object sender, EventArgs e)
		{
			query = "select * from EndClass.dbo.Product";
			int changes = dBAccess.executeDataAdapter(dtProducts, query);
			MessageBox.Show("There is " + changes + " changes");
		}

		private void productsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 4)
			{
				OpenFileDialog ofd = new OpenFileDialog();
				ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					String strFilePath = ofd.FileName;
					productPicture.Image = new Bitmap(strFilePath);
					if (imgTitle.Text.Trim().Length == 0)//Auto-Fill title if is empty
						imgTitle.Text = System.IO.Path.GetFileName(strFilePath);

					// convert bitmap to jpeg
					Image temp = new Bitmap(strFilePath);
					MemoryStream strm = new MemoryStream();
					temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
					Byte[] ImageByteArray = strm.ToArray();

					dtProducts.Rows[e.RowIndex].SetField(4, ImageByteArray);
				}
			}
		}
	}
}
