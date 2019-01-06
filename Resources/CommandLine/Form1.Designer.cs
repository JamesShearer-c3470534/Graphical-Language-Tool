namespace TestCommandLine
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtCommandLine = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lvwResults = new System.Windows.Forms.ListView();
			this.btnParse = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sample &command line:";
			// 
			// txtCommandLine
			// 
			this.txtCommandLine.Location = new System.Drawing.Point(12, 25);
			this.txtCommandLine.Name = "txtCommandLine";
			this.txtCommandLine.Size = new System.Drawing.Size(411, 20);
			this.txtCommandLine.TabIndex = 1;
			this.txtCommandLine.Text = "arg1 \"c:\\program files\\filename.txt\" /a -b:arg2 /c-d:arg3/e:\"arg  4\"";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "&Results:";
			// 
			// lvwResults
			// 
			this.lvwResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lvwResults.FullRowSelect = true;
			this.lvwResults.GridLines = true;
			this.lvwResults.Location = new System.Drawing.Point(12, 70);
			this.lvwResults.Name = "lvwResults";
			this.lvwResults.Size = new System.Drawing.Size(411, 186);
			this.lvwResults.TabIndex = 3;
			this.lvwResults.UseCompatibleStateImageBehavior = false;
			this.lvwResults.View = System.Windows.Forms.View.Details;
			// 
			// btnParse
			// 
			this.btnParse.Location = new System.Drawing.Point(267, 268);
			this.btnParse.Name = "btnParse";
			this.btnParse.Size = new System.Drawing.Size(75, 23);
			this.btnParse.TabIndex = 4;
			this.btnParse.Text = "&Parse";
			this.btnParse.UseVisualStyleBackColor = true;
			this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(348, 268);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Type";
			this.columnHeader1.Width = 120;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Value";
			this.columnHeader2.Width = 120;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Flag Argument";
			this.columnHeader3.Width = 120;
			// 
			// Form1
			// 
			this.AcceptButton = this.btnParse;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(435, 306);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnParse);
			this.Controls.Add(this.lvwResults);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCommandLine);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Test CommandLine";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCommandLine;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListView lvwResults;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button btnParse;
		private System.Windows.Forms.Button btnClose;
	}
}

