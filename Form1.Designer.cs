
namespace MidClass
{
	partial class Form1
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
			this.testb = new System.Windows.Forms.Button();
			this.Title = new System.Windows.Forms.Label();
			this.UpdateUsers = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// testb
			// 
			this.testb.Location = new System.Drawing.Point(541, 345);
			this.testb.Name = "testb";
			this.testb.Size = new System.Drawing.Size(75, 23);
			this.testb.TabIndex = 19;
			this.testb.Text = "button1";
			this.testb.UseVisualStyleBackColor = true;
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Title.Location = new System.Drawing.Point(297, 40);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(151, 22);
			this.Title.TabIndex = 18;
			this.Title.Text = "List of all users";
			// 
			// UpdateUsers
			// 
			this.UpdateUsers.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdateUsers.Location = new System.Drawing.Point(185, 371);
			this.UpdateUsers.Name = "UpdateUsers";
			this.UpdateUsers.Size = new System.Drawing.Size(383, 40);
			this.UpdateUsers.TabIndex = 17;
			this.UpdateUsers.Text = "Update Users";
			this.UpdateUsers.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(185, 66);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(383, 273);
			this.dataGridView1.TabIndex = 16;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.testb);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.UpdateUsers);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button testb;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Button UpdateUsers;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}