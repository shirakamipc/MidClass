
namespace MidClass
{
	partial class AdController
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
			this.AllUsers = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.mailtxt = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.unametxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.AllProducts = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AllUsers
			// 
			this.AllUsers.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AllUsers.Location = new System.Drawing.Point(23, 228);
			this.AllUsers.Name = "AllUsers";
			this.AllUsers.Size = new System.Drawing.Size(169, 34);
			this.AllUsers.TabIndex = 18;
			this.AllUsers.Text = "See All Users";
			this.AllUsers.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(282, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 22);
			this.label1.TabIndex = 17;
			this.label1.Text = "Admin controller";
			// 
			// mailtxt
			// 
			this.mailtxt.Enabled = false;
			this.mailtxt.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mailtxt.Location = new System.Drawing.Point(128, 88);
			this.mailtxt.Name = "mailtxt";
			this.mailtxt.Size = new System.Drawing.Size(264, 29);
			this.mailtxt.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 22);
			this.label3.TabIndex = 15;
			this.label3.Text = "E-Mail";
			// 
			// unametxt
			// 
			this.unametxt.Enabled = false;
			this.unametxt.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.unametxt.Location = new System.Drawing.Point(128, 46);
			this.unametxt.Name = "unametxt";
			this.unametxt.Size = new System.Drawing.Size(264, 29);
			this.unametxt.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 22);
			this.label2.TabIndex = 13;
			this.label2.Text = "User Name";
			// 
			// AllProducts
			// 
			this.AllProducts.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AllProducts.Location = new System.Drawing.Point(459, 228);
			this.AllProducts.Name = "AllProducts";
			this.AllProducts.Size = new System.Drawing.Size(183, 34);
			this.AllProducts.TabIndex = 20;
			this.AllProducts.Text = "See All Products";
			this.AllProducts.UseVisualStyleBackColor = true;
			this.AllProducts.Click += new System.EventHandler(this.AllProducts_Click);
			// 
			// AdController
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.AllProducts);
			this.Controls.Add(this.AllUsers);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mailtxt);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.unametxt);
			this.Controls.Add(this.label2);
			this.Name = "AdController";
			this.Text = "Admin Controller";
			this.Load += new System.EventHandler(this.AdController_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AllUsers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox mailtxt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox unametxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button AllProducts;
	}
}