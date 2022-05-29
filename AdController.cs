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
	public partial class AdController : Form
	{

		private void AllUsers_Click(object sender,EventArgs e)
		{
			AllUsers users = new AllUsers();
			users.Show();
		}

		public AdController()
		{
			InitializeComponent();
			AllUsers.Click += new EventHandler(AllUsers_Click) ;
		}

		private void AdController_Load(object sender, EventArgs e)
		{
			unametxt.Text = SignIn.uName;
			mailtxt.Text = SignIn.mail;
		}

		private void AllProducts_Click(object sender, EventArgs e)
		{
			Allproducts2 allproducts2 = new Allproducts2();
			allproducts2.Show();
		}
	}
}
