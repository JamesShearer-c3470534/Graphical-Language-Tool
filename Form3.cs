<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalLanguageTool
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {




        }
    }
=======
﻿
using System;
using System.Windows.Forms;
using BlackBeltCoder;

namespace TestCommandLine
{
	public partial class Form3 : Form
	{
		public Form3()
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
>>>>>>> bfa5cdce0a097982385df5656acf262ba42916a7
}
