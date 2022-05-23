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
	public partial class SignIn : Form
	{
		DBAccess dBAccess = new DBAccess();
		public SignIn()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e) // sign in button
		{
			string uname = unametxt.Text;
			string pword = pwordtxt.Text;
			if (uname.Equals(""))
			{
				MessageBox.Show("Enter your username");
			}
			else if (pword.Equals(""))
			{
				MessageBox.Show("Enter your password");
			}
			else
			{
				string query = "select id from Users where Users.UName = '"+ uname + "'and Users.Password =' "+pword+"'";

			}
		}
	}
}
