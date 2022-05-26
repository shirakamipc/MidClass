
namespace MidClass
{
	partial class AllUsers
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Previous = new System.Windows.Forms.Button();
			this.Next = new System.Windows.Forms.Button();
			this.UpdateUsers = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(43, 35);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(638, 273);
			this.dataGridView1.TabIndex = 0;
			// 
			// Previous
			// 
			this.Previous.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Previous.Location = new System.Drawing.Point(43, 340);
			this.Previous.Name = "Previous";
			this.Previous.Size = new System.Drawing.Size(143, 40);
			this.Previous.TabIndex = 1;
			this.Previous.Text = "Previous Users";
			this.Previous.UseVisualStyleBackColor = true;
			// 
			// Next
			// 
			this.Next.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Next.Location = new System.Drawing.Point(538, 340);
			this.Next.Name = "Next";
			this.Next.Size = new System.Drawing.Size(143, 40);
			this.Next.TabIndex = 2;
			this.Next.Text = "Next Users";
			this.Next.UseVisualStyleBackColor = true;
			// 
			// UpdateUsers
			// 
			this.UpdateUsers.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdateUsers.Location = new System.Drawing.Point(283, 340);
			this.UpdateUsers.Name = "UpdateUsers";
			this.UpdateUsers.Size = new System.Drawing.Size(143, 40);
			this.UpdateUsers.TabIndex = 3;
			this.UpdateUsers.Text = "Update Users";
			this.UpdateUsers.UseVisualStyleBackColor = true;
			// 
			// AllUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.UpdateUsers);
			this.Controls.Add(this.Next);
			this.Controls.Add(this.Previous);
			this.Controls.Add(this.dataGridView1);
			this.Name = "AllUsers";
			this.Text = "AllUsers";
			this.Load += new System.EventHandler(this.AllUsers_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Previous;
		private System.Windows.Forms.Button Next;
		private System.Windows.Forms.Button UpdateUsers;
	}
}