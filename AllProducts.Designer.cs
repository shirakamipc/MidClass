
namespace MidClass
{
	partial class Allproducts
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
			this.Title = new System.Windows.Forms.Label();
			this.UpdateUsers = new System.Windows.Forms.Button();
			this.productsGrid = new System.Windows.Forms.DataGridView();
			this.productPicture = new System.Windows.Forms.PictureBox();
			this.imgTitle = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Title.Location = new System.Drawing.Point(208, 18);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(182, 22);
			this.Title.TabIndex = 17;
			this.Title.Text = "List of all products";
			// 
			// UpdateUsers
			// 
			this.UpdateUsers.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdateUsers.Location = new System.Drawing.Point(93, 336);
			this.UpdateUsers.Name = "UpdateUsers";
			this.UpdateUsers.Size = new System.Drawing.Size(383, 40);
			this.UpdateUsers.TabIndex = 16;
			this.UpdateUsers.Text = "Update Products";
			this.UpdateUsers.UseVisualStyleBackColor = true;
			this.UpdateUsers.Click += new System.EventHandler(this.UpdateProducts_Click);
			// 
			// productsGrid
			// 
			this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productsGrid.Location = new System.Drawing.Point(14, 44);
			this.productsGrid.Name = "productsGrid";
			this.productsGrid.Size = new System.Drawing.Size(548, 273);
			this.productsGrid.TabIndex = 15;
			this.productsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGrid_CellContentClick);
			this.productsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGrid_CellContentDoubleClick);
			// 
			// productPicture
			// 
			this.productPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.productPicture.Location = new System.Drawing.Point(579, 44);
			this.productPicture.Name = "productPicture";
			this.productPicture.Size = new System.Drawing.Size(209, 273);
			this.productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.productPicture.TabIndex = 18;
			this.productPicture.TabStop = false;
			// 
			// imgTitle
			// 
			this.imgTitle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.imgTitle.Location = new System.Drawing.Point(642, 14);
			this.imgTitle.Name = "imgTitle";
			this.imgTitle.Size = new System.Drawing.Size(100, 29);
			this.imgTitle.TabIndex = 19;
			// 
			// Allproducts2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.imgTitle);
			this.Controls.Add(this.productPicture);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.UpdateUsers);
			this.Controls.Add(this.productsGrid);
			this.Name = "Allproducts2";
			this.Text = "Allproducts2";
			this.Load += new System.EventHandler(this.Allproducts2_Load);
			((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Button UpdateUsers;
		private System.Windows.Forms.DataGridView productsGrid;
		private System.Windows.Forms.PictureBox productPicture;
		private System.Windows.Forms.TextBox imgTitle;
	}
}