
namespace MidClass
{
	partial class AllProducts
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
			this.ChangeProducts = new System.Windows.Forms.Button();
			this.productsGridView = new System.Windows.Forms.DataGridView();
			this.NewProduct = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Title.Location = new System.Drawing.Point(260, 33);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(182, 22);
			this.Title.TabIndex = 17;
			this.Title.Text = "List of all products";
			// 
			// ChangeProducts
			// 
			this.ChangeProducts.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChangeProducts.Location = new System.Drawing.Point(66, 354);
			this.ChangeProducts.Name = "ChangeProducts";
			this.ChangeProducts.Size = new System.Drawing.Size(191, 40);
			this.ChangeProducts.TabIndex = 16;
			this.ChangeProducts.Text = "Change Products";
			this.ChangeProducts.UseVisualStyleBackColor = true;
			this.ChangeProducts.Click += new System.EventHandler(this.ChangeProducts_Click);
			// 
			// productsGridView
			// 
			this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productsGridView.Location = new System.Drawing.Point(66, 59);
			this.productsGridView.Name = "productsGridView";
			this.productsGridView.Size = new System.Drawing.Size(548, 273);
			this.productsGridView.TabIndex = 15;
			// 
			// NewProduct
			// 
			this.NewProduct.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NewProduct.Location = new System.Drawing.Point(423, 354);
			this.NewProduct.Name = "NewProduct";
			this.NewProduct.Size = new System.Drawing.Size(191, 40);
			this.NewProduct.TabIndex = 18;
			this.NewProduct.Text = "New Product";
			this.NewProduct.UseVisualStyleBackColor = true;
			// 
			// AllProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(663, 450);
			this.Controls.Add(this.NewProduct);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.ChangeProducts);
			this.Controls.Add(this.productsGridView);
			this.Name = "AllProducts";
			this.Text = "AllProducts";
			this.Load += new System.EventHandler(this.AllProducts_Load);
			((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Button ChangeProducts;
		private System.Windows.Forms.DataGridView productsGridView;
		private System.Windows.Forms.Button NewProduct;
	}
}