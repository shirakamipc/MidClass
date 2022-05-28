namespace MidClass
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.pbxImage = new System.Windows.Forms.PictureBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.dgvImages = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvImages)).BeginInit();
			this.SuspendLayout();
			// 
			// pbxImage
			// 
			this.pbxImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbxImage.Image = ((System.Drawing.Image)(resources.GetObject("pbxImage.Image")));
			this.pbxImage.Location = new System.Drawing.Point(440, 46);
			this.pbxImage.Name = "pbxImage";
			this.pbxImage.Size = new System.Drawing.Size(409, 416);
			this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxImage.TabIndex = 0;
			this.pbxImage.TabStop = false;
			// 
			// btnBrowse
			// 
			this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBrowse.Location = new System.Drawing.Point(12, 83);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(422, 48);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtTitle
			// 
			this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTitle.Location = new System.Drawing.Point(12, 46);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(422, 31);
			this.txtTitle.TabIndex = 2;
			// 
			// dgvImages
			// 
			this.dgvImages.AllowUserToAddRows = false;
			this.dgvImages.AllowUserToDeleteRows = false;
			this.dgvImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvImages.Location = new System.Drawing.Point(12, 213);
			this.dgvImages.Name = "dgvImages";
			this.dgvImages.ReadOnly = true;
			this.dgvImages.RowTemplate.Height = 30;
			this.dgvImages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvImages.Size = new System.Drawing.Size(422, 249);
			this.dgvImages.TabIndex = 3;
			this.dgvImages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImages_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(168, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Image Title";
			// 
			// btnSave
			// 
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(12, 159);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(194, 48);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(587, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Image Preview";
			// 
			// btnClear
			// 
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(240, 159);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(194, 48);
			this.btnClear.TabIndex = 1;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(861, 474);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvImages);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.pbxImage);
			this.Name = "frmMain";
			this.ShowIcon = false;
			this.Text = "Save Image to Sql Server";
			((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvImages)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbxImage;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.DataGridView dgvImages;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnClear;
	}
}

