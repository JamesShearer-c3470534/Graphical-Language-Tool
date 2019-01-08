//////////////////////////////////////////////////////////////////////////////
// This source code and all associated files and resources are copyrighted by
// the author(s). This source code and all associated files and resources may
// be used as long as they are used according to the terms and conditions set
// forth in The Code Project Open License (CPOL), which may be viewed at
// http://www.blackbeltcoder.com/Legal/Licenses/CPOL.
//
// Copyright (c) 2011 Jonathan Wood
//

using System;
using System.Windows.Forms;
using BlackBeltCoder;

namespace TestCommandLine
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnParse_Click(object sender, EventArgs e)
		{
			CommandLine cmd = new CommandLine(txtCommandLine.Text);
			lvwResults.Items.Clear();

			// Add arguments to list
			foreach (string arg in cmd.Arguments)
			{
				ListViewItem item = new ListViewItem();
				item.Text = "Argument";
				item.SubItems.Add(arg);
				lvwResults.Items.Add(item);
			}

			// Add flags to list
			foreach (CommandLineFlag flag in cmd.Flags)
			{
				ListViewItem item = new ListViewItem();
				item.Text = "Flag";
				item.SubItems.Add(flag.Flag);
				if (flag.Argument != null)
					item.SubItems.Add(flag.Argument);
				lvwResults.Items.Add(item);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
