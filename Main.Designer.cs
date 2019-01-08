using System;

namespace GraphicalLanguageTool
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtCode = new ICSharpCode.TextEditor.TextEditorControl();
            this.MS1 = new System.Windows.Forms.MenuStrip();
            this.FILE = new System.Windows.Forms.ToolStripMenuItem();
            this.NEW = new System.Windows.Forms.ToolStripMenuItem();
            this.OPEN = new System.Windows.Forms.ToolStripMenuItem();
            this.STS1 = new System.Windows.Forms.ToolStripSeparator();
            this.SUBMIT = new System.Windows.Forms.ToolStripMenuItem();
            this.STS2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.STS3 = new System.Windows.Forms.ToolStripSeparator();
            this.EXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.Iteration = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonselectionif = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonselectionelse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.HELP = new System.Windows.Forms.ToolStripMenuItem();
            this.ABOUT = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.selectionifpanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.selectionelsepanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BF = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LF = new System.Windows.Forms.TextBox();
            this.TTF = new System.Windows.Forms.ToolTip(this.components);
            this.USERNAMETXT = new System.Windows.Forms.TextBox();
            this.LBUSERNAME = new System.Windows.Forms.Label();
            this.MS1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.selectionifpanel.SuspendLayout();
            this.selectionelsepanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCode.IsReadOnly = false;
            this.txtCode.Location = new System.Drawing.Point(0, 327);
            this.txtCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtCode.MinimumSize = new System.Drawing.Size(100, 300);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(1134, 401);
            this.txtCode.TabIndex = 24;
            this.txtCode.Load += new System.EventHandler(this.TxtCode_Load);
            // 
            // MS1
            // 
            this.MS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FILE,
            this.Iteration,
            this.toolStripMenuItem7,
            this.toolStripMenuItem11,
            this.button1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem12,
            this.HELP});
            this.MS1.Location = new System.Drawing.Point(0, 0);
            this.MS1.Name = "MS1";
            this.MS1.Size = new System.Drawing.Size(1134, 24);
            this.MS1.TabIndex = 25;
            this.MS1.Text = "MS1";
            this.MS1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MS1_ItemClicked);
            // 
            // FILE
            // 
            this.FILE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NEW,
            this.OPEN,
            this.STS1,
            this.SUBMIT,
            this.STS2,
            this.logoutToolStripMenuItem,
            this.STS3,
            this.EXIT});
            this.FILE.Name = "FILE";
            this.FILE.Size = new System.Drawing.Size(37, 20);
            this.FILE.Text = "File";
            // 
            // NEW
            // 
            this.NEW.Name = "NEW";
            this.NEW.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NEW.Size = new System.Drawing.Size(203, 22);
            this.NEW.Text = "New Statement";
            this.NEW.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OPEN
            // 
            this.OPEN.Name = "OPEN";
            this.OPEN.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OPEN.Size = new System.Drawing.Size(203, 22);
            this.OPEN.Text = "Open Statement";
            this.OPEN.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // STS1
            // 
            this.STS1.Name = "STS1";
            this.STS1.Size = new System.Drawing.Size(200, 6);
            // 
            // SUBMIT
            // 
            this.SUBMIT.Name = "SUBMIT";
            this.SUBMIT.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SUBMIT.Size = new System.Drawing.Size(203, 22);
            this.SUBMIT.Text = "Save";
            this.SUBMIT.Click += new System.EventHandler(this.SubmitAuditToolStripMenuItem_Click);
            // 
            // STS2
            // 
            this.STS2.Name = "STS2";
            this.STS2.Size = new System.Drawing.Size(200, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // STS3
            // 
            this.STS3.Name = "STS3";
            this.STS3.Size = new System.Drawing.Size(200, 6);
            // 
            // EXIT
            // 
            this.EXIT.Name = "EXIT";
            this.EXIT.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.EXIT.Size = new System.Drawing.Size(203, 22);
            this.EXIT.Text = "Exit";
            this.EXIT.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Iteration
            // 
            this.Iteration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonselectionif,
            this.buttonselectionelse,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.Iteration.Name = "Iteration";
            this.Iteration.Size = new System.Drawing.Size(67, 20);
            this.Iteration.Text = "Selection";
            // 
            // buttonselectionif
            // 
            this.buttonselectionif.Name = "buttonselectionif";
            this.buttonselectionif.Size = new System.Drawing.Size(112, 22);
            this.buttonselectionif.Text = "If";
            this.buttonselectionif.Click += new System.EventHandler(this.buttonselectionif_Click);
            // 
            // buttonselectionelse
            // 
            this.buttonselectionelse.Name = "buttonselectionelse";
            this.buttonselectionelse.Size = new System.Drawing.Size(112, 22);
            this.buttonselectionelse.Text = "Else";
            this.buttonselectionelse.Click += new System.EventHandler(this.buttonselectionelse_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem4.Text = "Switch";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem5.Text = "Case";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem6.Text = "Default";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem7.Text = "Iteration";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem1.Text = "Do";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem8.Text = "For";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem9.Text = "foreach, in";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem10.Text = "While";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem11.Text = "Sequence";
            // 
            // button1
            // 
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.Text = "Paint Tool";
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(101, 20);
            this.toolStripMenuItem2.Text = "Command Line";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // HELP
            // 
            this.HELP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ABOUT});
            this.HELP.Name = "HELP";
            this.HELP.Size = new System.Drawing.Size(44, 20);
            this.HELP.Text = "Help";
            // 
            // ABOUT
            // 
            this.ABOUT.Name = "ABOUT";
            this.ABOUT.Size = new System.Drawing.Size(107, 22);
            this.ABOUT.Text = "About";
            this.ABOUT.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(135, 20);
            this.toolStripMenuItem12.Text = "Factory Class example";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.MaximumSize = new System.Drawing.Size(1200, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(205, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 303);
            this.panel1.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(653, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 290);
            this.panel3.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.selectionifpanel);
            this.panel4.Location = new System.Drawing.Point(12, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(638, 290);
            this.panel4.TabIndex = 31;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // selectionifpanel
            // 
            this.selectionifpanel.Controls.Add(this.textBox1);
            this.selectionifpanel.Controls.Add(this.selectionelsepanel);
            this.selectionifpanel.Controls.Add(this.label3);
            this.selectionifpanel.Location = new System.Drawing.Point(-1, 3);
            this.selectionifpanel.Name = "selectionifpanel";
            this.selectionifpanel.Size = new System.Drawing.Size(634, 286);
            this.selectionifpanel.TabIndex = 0;
            this.selectionifpanel.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(32, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(586, 241);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // selectionelsepanel
            // 
            this.selectionelsepanel.Controls.Add(this.textBox2);
            this.selectionelsepanel.Controls.Add(this.panel5);
            this.selectionelsepanel.Controls.Add(this.label4);
            this.selectionelsepanel.Location = new System.Drawing.Point(32, -1);
            this.selectionelsepanel.Name = "selectionelsepanel";
            this.selectionelsepanel.Size = new System.Drawing.Size(601, 286);
            this.selectionelsepanel.TabIndex = 1;
            this.selectionelsepanel.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(0, 31);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(586, 241);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(601, 286);
            this.panel5.TabIndex = 3;
            this.panel5.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(491, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Selection - Else Statement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Selection - Else Statement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Selection - If Statement";
            // 
            // BF
            // 
            this.BF.Location = new System.Drawing.Point(22, 249);
            this.BF.Name = "BF";
            this.BF.Size = new System.Drawing.Size(112, 29);
            this.BF.TabIndex = 30;
            this.BF.Text = "Change";
            this.TTF.SetToolTip(this.BF, "Only source code creator may change \'Fixed\' status of bug.");
            this.BF.UseVisualStyleBackColor = true;
            this.BF.Visible = false;
            this.BF.Click += new System.EventHandler(this.ButtonFix_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LF);
            this.panel2.Controls.Add(this.BF);
            this.panel2.Location = new System.Drawing.Point(967, 24);
            this.panel2.MaximumSize = new System.Drawing.Size(500, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 290);
            this.panel2.TabIndex = 29;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LF
            // 
            this.LF.BackColor = System.Drawing.SystemColors.Control;
            this.LF.Cursor = System.Windows.Forms.Cursors.Default;
            this.LF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LF.Location = new System.Drawing.Point(22, 223);
            this.LF.Name = "LF";
            this.LF.ReadOnly = true;
            this.LF.Size = new System.Drawing.Size(112, 20);
            this.LF.TabIndex = 31;
            this.LF.Text = "Unfixed";
            this.LF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTF.SetToolTip(this.LF, "Only source code creator may change \'Fixed\' status of bug.");
            this.LF.Visible = false;
            // 
            // USERNAMETXT
            // 
            this.USERNAMETXT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.USERNAMETXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.USERNAMETXT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAMETXT.Location = new System.Drawing.Point(1012, 4);
            this.USERNAMETXT.Name = "USERNAMETXT";
            this.USERNAMETXT.ReadOnly = true;
            this.USERNAMETXT.Size = new System.Drawing.Size(110, 16);
            this.USERNAMETXT.TabIndex = 3;
            this.USERNAMETXT.TextChanged += new System.EventHandler(this.USERNAMETXT_TextChanged);
            // 
            // LBUSERNAME
            // 
            this.LBUSERNAME.AutoSize = true;
            this.LBUSERNAME.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBUSERNAME.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBUSERNAME.Location = new System.Drawing.Point(915, 2);
            this.LBUSERNAME.Name = "LBUSERNAME";
            this.LBUSERNAME.Size = new System.Drawing.Size(91, 17);
            this.LBUSERNAME.TabIndex = 6;
            this.LBUSERNAME.Text = "Logged in as:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1134, 728);
            this.Controls.Add(this.USERNAMETXT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LBUSERNAME);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.MS1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MS1;
            this.MinimumSize = new System.Drawing.Size(936, 767);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphical Language Tool";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MS1.ResumeLayout(false);
            this.MS1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.selectionifpanel.ResumeLayout(false);
            this.selectionifpanel.PerformLayout();
            this.selectionelsepanel.ResumeLayout(false);
            this.selectionelsepanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private ICSharpCode.TextEditor.TextEditorControl txtCode;
        private System.Windows.Forms.MenuStrip MS1;
        private System.Windows.Forms.ToolStripMenuItem FILE;
        private System.Windows.Forms.ToolStripMenuItem EXIT;
        private System.Windows.Forms.ToolStripMenuItem NEW;
        private System.Windows.Forms.ToolStripMenuItem OPEN;
        private System.Windows.Forms.ToolStripMenuItem HELP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem SUBMIT;
        private System.Windows.Forms.ToolStripSeparator STS1;
        private System.Windows.Forms.ToolStripSeparator STS2;
        private System.Windows.Forms.ToolStripSeparator STS3;
        private System.Windows.Forms.Button BF;
        private System.Windows.Forms.ToolTip TTF;
        private System.Windows.Forms.ToolStripMenuItem ABOUT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem Iteration;
        private System.Windows.Forms.ToolStripMenuItem buttonselectionif;
        private System.Windows.Forms.ToolStripMenuItem buttonselectionelse;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.Panel selectionifpanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel selectionelsepanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem button1;
        private System.Windows.Forms.TextBox LF;
        private System.Windows.Forms.TextBox USERNAMETXT;
        private System.Windows.Forms.Label LBUSERNAME;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
    }
}

