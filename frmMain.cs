using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Author : Dotnet Mob
//Blog : http://dotnetmob.com/
//Youtube : https://www.youtube.com/c/DotnetMob
//Date : 12-Oct-2016
//Description : Save Image to Sql Server using C#

namespace MidClass
{
    public partial class frmMain : Form
    {

        #region Variables
        int ImageID = 0;
        String strFilePath = "";
        Image DefaultImage;
        Byte[] ImageByteArray;
        //before executing -create database with given script - change connection string according to yours
        SqlConnection sqlcon = new SqlConnection("Data Source=\"localhost, 1433\";User ID=sa;Password=\"Database 2019\";Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        DBAccess dBAccess = new DBAccess();
        DataTable dtblImages = new DataTable();
        #endregion

        #region Methods
        public frmMain()
        {
            InitializeComponent();
            DefaultImage = pbxImage.Image;
            RefreshImageGrid();
        }
        void RefreshImageGrid()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
           
            string query = "select iid,iname,iimg from EndClass.dbo.image_t";
            SqlDataAdapter sqlda = dBAccess.readDatathroughAdapter(query, dtblImages);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            
            //sqlda.Fill(dtblImages);
            dgvImages.DataSource = dtblImages;
            dgvImages.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvImages.Columns[2].Visible = false;
        }
        void Clear()
        {
            ImageID = 0;
            txtTitle.Clear();
            pbxImage.Image = DefaultImage;
            strFilePath = "";
            btnSave.Text = "Save";
        }
        #endregion

        #region Events
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strFilePath = ofd.FileName;
                pbxImage.Image = new Bitmap(strFilePath);
                if (txtTitle.Text.Trim().Length == 0)//Auto-Fill title if is empty
                    txtTitle.Text = System.IO.Path.GetFileName(strFilePath);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim() != "")
            {

                if (strFilePath == "")
                {
                    if (ImageByteArray.Length != 0)
                        ImageByteArray = new byte[] { };
                }
                else //there is an img
                {
                    Image temp = new Bitmap(strFilePath);//img is here as bitmap
                    MemoryStream strm = new MemoryStream();
                    temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                    ImageByteArray = strm.ToArray();
                }
                
                // exeDataAdapter
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand("ImageAddOrEdit", sqlcon) { CommandType = CommandType.StoredProcedure };
                sqlCmd.Parameters.AddWithValue("@iid", ImageID);
                sqlCmd.Parameters.AddWithValue("@iname", txtTitle.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@iimg", ImageByteArray);
                sqlCmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Saved successfuly");
                Clear();
                RefreshImageGrid();
            }
            else
            {
                MessageBox.Show("Please enter image title");
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void dgvImages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTitle.Text = dgvImages.CurrentRow.Cells[1].Value.ToString();
            byte[] ImageArray = (byte[])dgvImages.CurrentRow.Cells[2].Value;
            if (ImageArray.Length == 0)
                pbxImage.Image = DefaultImage;
            else
            {
                ImageByteArray = ImageArray;
                pbxImage.Image = Image.FromStream(new MemoryStream(ImageArray));
            }
            ImageID = Convert.ToInt32(dgvImages.CurrentRow.Cells[0].Value);
            btnSave.Text = "Update";
        }
        #endregion
    }
}
