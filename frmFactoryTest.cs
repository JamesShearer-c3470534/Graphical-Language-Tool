using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFactoryPattern
{
    public partial class frmFactoryTest : Form
    {
        public frmFactoryTest()
        {
            InitializeComponent();
        }

        private void frmFactoryTest_Load(object sender, EventArgs e)
        {

            
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            IGet ObjIntrface = null;
            ObjIntrface = clsFactory.CreateandReturnObj(cmbSelect.SelectedIndex + 1);
            string res = ObjIntrface.ConC("First", "Second");
            lblResult.Text = res;
        }
    }

    class clsFactory
    {
        static public IGet CreateandReturnObj(int cChoice)
        {
            IGet ObjSelector = null;
            switch (cChoice)
            {
                case 1:
                    ObjSelector = new clsFirst();
                    break;
                case 2:
                    ObjSelector = new clsSecond();
                    break;
                default:
                    ObjSelector = new clsFirst();
                    break;
            }
            return ObjSelector;

        }


    }

    interface IGet
    {
        string ConC(string s1, string s2);
    }



    class clsFirst : IGet
    {
        public string ConC(string s1, string s2)
        {
            string Final = "From First: " + s1+" and " + s2;
            return Final;
        }
    }

    class clsSecond : IGet
    {
        public string ConC(string s1, string s2)
        {
            string Final = "From Second: " + s1 + " and " + s2;
            return Final;
        }
    }

}
