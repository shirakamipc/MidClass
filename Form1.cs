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
	public partial class Form1 : Form
	{


		public Form1()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = AllUsers.dtUsers;

			for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
			{
				dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
		}
	}
}
