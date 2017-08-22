namespace SimpleCalcGui
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
			this.cmdCalculate = new System.Windows.Forms.Button();
			this.txtArea = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtHeight = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtWidth = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cmdCalculate
			// 
			this.cmdCalculate.Location = new System.Drawing.Point(199, 59);
			this.cmdCalculate.Name = "cmdCalculate";
			this.cmdCalculate.Size = new System.Drawing.Size(75, 23);
			this.cmdCalculate.TabIndex = 27;
			this.cmdCalculate.Text = "Calculate";
			this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
			// 
			// txtArea
			// 
			this.txtArea.Location = new System.Drawing.Point(87, 99);
			this.txtArea.Name = "txtArea";
			this.txtArea.ReadOnly = true;
			this.txtArea.Size = new System.Drawing.Size(80, 20);
			this.txtArea.TabIndex = 26;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(23, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 25;
			this.label3.Text = "Area";
			// 
			// txtHeight
			// 
			this.txtHeight.Location = new System.Drawing.Point(87, 59);
			this.txtHeight.Name = "txtHeight";
			this.txtHeight.Size = new System.Drawing.Size(80, 20);
			this.txtHeight.TabIndex = 24;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(23, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 23;
			this.label2.Text = "Height";
			// 
			// txtWidth
			// 
			this.txtWidth.Location = new System.Drawing.Point(87, 19);
			this.txtWidth.Name = "txtWidth";
			this.txtWidth.Size = new System.Drawing.Size(80, 20);
			this.txtWidth.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(23, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 21;
			this.label1.Text = "Width";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 141);
			this.Controls.Add(this.cmdCalculate);
			this.Controls.Add(this.txtArea);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtHeight);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtWidth);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Rectangle Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdCalculate;
		private System.Windows.Forms.TextBox txtArea;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtHeight;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtWidth;
		private System.Windows.Forms.Label label1;
	}
}

