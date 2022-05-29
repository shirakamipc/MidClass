using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

		private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{

		}

		private void productBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
		{
			this.Validate();
			this.productBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dSProducts);

		}

		private void AllProducts_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dSProducts.Product' table. You can move, or remove it, as needed.
			this.productTableAdapter.Fill(this.dSProducts.Product);

		}

		private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 4)
			{
				OpenFileDialog ofd = new OpenFileDialog();
				ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					String strFilePath = ofd.FileName;
					//pbxImage.Image = new Bitmap(strFilePath);
					if (imgText.Text.Trim().Length == 0)//Auto-Fill title if is empty
						imgText.Text = System.IO.Path.GetFileName(strFilePath);

					// convert bitmap to jpeg
					Image temp = new Bitmap(strFilePath);
					MemoryStream strm = new MemoryStream();
					temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
					Byte[] ImageByteArray = strm.ToArray();

					//save to database
				}
			}
		}
	}
}
