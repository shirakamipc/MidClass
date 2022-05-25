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
		public static string uId, uName, mail,pWord; //display user information 
		
		DBAccess dBAccess = new DBAccess();

		DataTable dtUser = new DataTable();
		public SignIn()
		{
			InitializeComponent();
		}

		private void SignIn_Load(object sender, EventArgs e)
		{

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
				string query = "use EndClass;select * from Users where Users.UName = '" + uname + "'and Users.Password ='"+pword+"'";//sql injection

				dBAccess.readDatathroughAdapter(query, dtUser);

				if (dtUser.Rows.Count == 0)
				{
					MessageBox.Show("Your username or password is wrong");
				}
				else if(dtUser.Rows.Count > 1)
				{
					//push to error log
				}
				if (dtUser.Rows.Count >= 1)
				{
					uId = dtUser.Rows[0]["UId"].ToString();
					uName = dtUser.Rows[0]["UName"].ToString();
					mail  = dtUser.Rows[0]["Mail"].ToString();
					pWord = dtUser.Rows[0]["Password"].ToString();

					MessageBox.Show("Log in completed");
					dBAccess.closeConn();

					this.Hide();
					if (uId.Equals("1"))
					{
						AdController home = new AdController();
						home.Show();
					}
					else
					{
						MessageBox.Show("This is not admin account \n Please use admin account or use web login");
					}
				}
			}
		}
	}
}
