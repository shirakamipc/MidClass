
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
			this.UpdateUsers = new System.Windows.Forms.Button();
			this.Title = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(43, 35);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(383, 273);
			this.dataGridView1.TabIndex = 0;
			// 
			// UpdateUsers
			// 
			this.UpdateUsers.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdateUsers.Location = new System.Drawing.Point(43, 340);
			this.UpdateUsers.Name = "UpdateUsers";
			this.UpdateUsers.Size = new System.Drawing.Size(383, 40);
			this.UpdateUsers.TabIndex = 3;
			this.UpdateUsers.Text = "Update Users";
			this.UpdateUsers.UseVisualStyleBackColor = true;
			this.UpdateUsers.Click += new System.EventHandler(this.UpdateUsers_Click_1);
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Title.Location = new System.Drawing.Point(155, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(151, 22);
			this.Title.TabIndex = 14;
			this.Title.Text = "List of all users";
			// 
			// AllUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 393);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.UpdateUsers);
			this.Controls.Add(this.dataGridView1);
			this.Name = "AllUsers";
			this.Text = "AllUsers";
			this.Load += new System.EventHandler(this.AllUsers_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button UpdateUsers;
		private System.Windows.Forms.Label Title;
	}
}