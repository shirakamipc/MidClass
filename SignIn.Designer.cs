﻿
namespace MidClass
{
	partial class SignIn
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.unametxt = new System.Windows.Forms.TextBox();
			this.pwordtxt = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(222, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sign In";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(84, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "User Name";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// unametxt
			// 
			this.unametxt.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.unametxt.Location = new System.Drawing.Point(200, 84);
			this.unametxt.Name = "unametxt";
			this.unametxt.Size = new System.Drawing.Size(264, 29);
			this.unametxt.TabIndex = 2;
			// 
			// pwordtxt
			// 
			this.pwordtxt.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pwordtxt.Location = new System.Drawing.Point(200, 126);
			this.pwordtxt.Name = "pwordtxt";
			this.pwordtxt.Size = new System.Drawing.Size(264, 29);
			this.pwordtxt.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(84, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 22);
			this.label3.TabIndex = 3;
			this.label3.Text = "Password";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(389, 193);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 32);
			this.button1.TabIndex = 5;
			this.button1.Text = "Sign In";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SignIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 289);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pwordtxt);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.unametxt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "SignIn";
			this.Text = "TBShop";
			this.Load += new System.EventHandler(this.SignIn_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox unametxt;
		private System.Windows.Forms.TextBox pwordtxt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
	}
}

