namespace GraphicalLanguageTool
{
    partial class NewBugForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBugForm));
            this.buttonNewBug = new System.Windows.Forms.Button();
            this.txtCodeNew = new ICSharpCode.TextEditor.TextEditorControl();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.txtAuthorNew = new System.Windows.Forms.TextBox();
            this.buttonNBCancel = new System.Windows.Forms.Button();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNewBug
            // 
            this.buttonNewBug.Location = new System.Drawing.Point(543, 404);
            this.buttonNewBug.Name = "buttonNewBug";
            this.buttonNewBug.Size = new System.Drawing.Size(65, 23);
            this.buttonNewBug.TabIndex = 45;
            this.buttonNewBug.Text = "Submit";
            this.buttonNewBug.UseVisualStyleBackColor = true;
            this.buttonNewBug.Click += new System.EventHandler(this.ButtonNewBug_Click);
            // 
            // txtCodeNew
            // 
            this.txtCodeNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodeNew.IsReadOnly = false;
            this.txtCodeNew.Location = new System.Drawing.Point(5, 5);
            this.txtCodeNew.Name = "txtCodeNew";
            this.txtCodeNew.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.txtCodeNew.Size = new System.Drawing.Size(614, 383);
            this.txtCodeNew.TabIndex = 46;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelAuthor.Location = new System.Drawing.Point(8, 5);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(47, 13);
            this.labelAuthor.TabIndex = 47;
            this.labelAuthor.Text = "Author:";
            // 
            // txtAuthorNew
            // 
            this.txtAuthorNew.BackColor = System.Drawing.SystemColors.Control;
            this.txtAuthorNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthorNew.Location = new System.Drawing.Point(85, 5);
            this.txtAuthorNew.Name = "txtAuthorNew";
            this.txtAuthorNew.Size = new System.Drawing.Size(82, 13);
            this.txtAuthorNew.TabIndex = 48;
            this.txtAuthorNew.Text = "testuser001";
            // 
            // buttonNBCancel
            // 
            this.buttonNBCancel.Location = new System.Drawing.Point(461, 404);
            this.buttonNBCancel.Name = "buttonNBCancel";
            this.buttonNBCancel.Size = new System.Drawing.Size(65, 23);
            this.buttonNBCancel.TabIndex = 49;
            this.buttonNBCancel.Text = "Cancel";
            this.buttonNBCancel.UseVisualStyleBackColor = true;
            this.buttonNBCancel.Click += new System.EventHandler(this.ButtonNBCancel_Click);
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "C++",
            "C#",
            "HTML",
            "Java",
            "Java Script",
            "PHP",
            "XML"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(543, 1);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(77, 21);
            this.comboBoxLanguage.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(467, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Language";
            // 
            // NewBugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.buttonNBCancel);
            this.Controls.Add(this.txtAuthorNew);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.txtCodeNew);
            this.Controls.Add(this.buttonNewBug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "NewBugForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNewBug;
        private ICSharpCode.TextEditor.TextEditorControl txtCodeNew;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox txtAuthorNew;
        private System.Windows.Forms.Button buttonNBCancel;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label label1;
    }
}