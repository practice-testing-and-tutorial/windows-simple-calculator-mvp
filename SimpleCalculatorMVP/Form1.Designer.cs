
namespace SimpleCalculatorMVP
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
			this.tbNumberOne = new System.Windows.Forms.TextBox();
			this.tbNumberTwo = new System.Windows.Forms.TextBox();
			this.tbResult = new System.Windows.Forms.TextBox();
			this.lbNumberOne = new System.Windows.Forms.Label();
			this.lbNumberTwo = new System.Windows.Forms.Label();
			this.lbResult = new System.Windows.Forms.Label();
			this.btnSumation = new System.Windows.Forms.Button();
			this.btnSubstraction = new System.Windows.Forms.Button();
			this.btnMultiplication = new System.Windows.Forms.Button();
			this.btnDivition = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbNumberOne
			// 
			this.tbNumberOne.Location = new System.Drawing.Point(85, 6);
			this.tbNumberOne.Name = "tbNumberOne";
			this.tbNumberOne.Size = new System.Drawing.Size(160, 20);
			this.tbNumberOne.TabIndex = 0;
			// 
			// tbNumberTwo
			// 
			this.tbNumberTwo.Location = new System.Drawing.Point(85, 36);
			this.tbNumberTwo.Name = "tbNumberTwo";
			this.tbNumberTwo.Size = new System.Drawing.Size(160, 20);
			this.tbNumberTwo.TabIndex = 1;
			// 
			// tbResult
			// 
			this.tbResult.Enabled = false;
			this.tbResult.Location = new System.Drawing.Point(85, 63);
			this.tbResult.Name = "tbResult";
			this.tbResult.Size = new System.Drawing.Size(160, 20);
			this.tbResult.TabIndex = 2;
			// 
			// lbNumberOne
			// 
			this.lbNumberOne.AutoSize = true;
			this.lbNumberOne.Location = new System.Drawing.Point(12, 9);
			this.lbNumberOne.Name = "lbNumberOne";
			this.lbNumberOne.Size = new System.Drawing.Size(67, 13);
			this.lbNumberOne.TabIndex = 3;
			this.lbNumberOne.Text = "Number One";
			// 
			// lbNumberTwo
			// 
			this.lbNumberTwo.AutoSize = true;
			this.lbNumberTwo.Location = new System.Drawing.Point(12, 39);
			this.lbNumberTwo.Name = "lbNumberTwo";
			this.lbNumberTwo.Size = new System.Drawing.Size(68, 13);
			this.lbNumberTwo.TabIndex = 4;
			this.lbNumberTwo.Text = "Number Two";
			// 
			// lbResult
			// 
			this.lbResult.AutoSize = true;
			this.lbResult.Location = new System.Drawing.Point(12, 66);
			this.lbResult.Name = "lbResult";
			this.lbResult.Size = new System.Drawing.Size(37, 13);
			this.lbResult.TabIndex = 5;
			this.lbResult.Text = "Result";
			// 
			// btnSumation
			// 
			this.btnSumation.Location = new System.Drawing.Point(83, 89);
			this.btnSumation.Name = "btnSumation";
			this.btnSumation.Size = new System.Drawing.Size(36, 23);
			this.btnSumation.TabIndex = 6;
			this.btnSumation.Text = "+";
			this.btnSumation.UseVisualStyleBackColor = true;
			this.btnSumation.Click += new System.EventHandler(this.btnSumation_Click);
			// 
			// btnSubstraction
			// 
			this.btnSubstraction.Location = new System.Drawing.Point(125, 89);
			this.btnSubstraction.Name = "btnSubstraction";
			this.btnSubstraction.Size = new System.Drawing.Size(36, 23);
			this.btnSubstraction.TabIndex = 7;
			this.btnSubstraction.Text = "-";
			this.btnSubstraction.UseVisualStyleBackColor = true;
			this.btnSubstraction.Click += new System.EventHandler(this.btnSubstraction_Click);
			// 
			// btnMultiplication
			// 
			this.btnMultiplication.Location = new System.Drawing.Point(167, 89);
			this.btnMultiplication.Name = "btnMultiplication";
			this.btnMultiplication.Size = new System.Drawing.Size(36, 23);
			this.btnMultiplication.TabIndex = 8;
			this.btnMultiplication.Text = "x";
			this.btnMultiplication.UseVisualStyleBackColor = true;
			this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
			// 
			// btnDivition
			// 
			this.btnDivition.Location = new System.Drawing.Point(209, 89);
			this.btnDivition.Name = "btnDivition";
			this.btnDivition.Size = new System.Drawing.Size(36, 23);
			this.btnDivition.TabIndex = 9;
			this.btnDivition.Text = "/";
			this.btnDivition.UseVisualStyleBackColor = true;
			this.btnDivition.Click += new System.EventHandler(this.btnDivition_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(260, 138);
			this.Controls.Add(this.btnDivition);
			this.Controls.Add(this.btnMultiplication);
			this.Controls.Add(this.btnSubstraction);
			this.Controls.Add(this.btnSumation);
			this.Controls.Add(this.lbResult);
			this.Controls.Add(this.lbNumberTwo);
			this.Controls.Add(this.lbNumberOne);
			this.Controls.Add(this.tbResult);
			this.Controls.Add(this.tbNumberTwo);
			this.Controls.Add(this.tbNumberOne);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbNumberOne;
		private System.Windows.Forms.TextBox tbNumberTwo;
		private System.Windows.Forms.TextBox tbResult;
		private System.Windows.Forms.Label lbNumberOne;
		private System.Windows.Forms.Label lbNumberTwo;
		private System.Windows.Forms.Label lbResult;
		private System.Windows.Forms.Button btnSumation;
		private System.Windows.Forms.Button btnSubstraction;
		private System.Windows.Forms.Button btnMultiplication;
		private System.Windows.Forms.Button btnDivition;
	}
}

