using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnsldworks_Click(object sender, EventArgs e)
        {
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();

            if (chkrevnumber.Checked == true)
            {
                string revnum = swApp.RevisionNumber();
                string[] arrrevnum = revnum.Split('.');
                
                int firstPart = int.Parse(arrrevnum[0]);

                if (firstPart > 28)
                {
                    swApp.SendMsgToUser2("SolidWorks version is greater than 2020", 2, 2);
                }
                else
                {
                    swApp.SendMsgToUser2("SolidWorks version is lesser than 2020", 2, 2);
                }
            }

            if (chkdisplaystatusbar.Checked == true)
            {
                swApp.DisplayStatusBar(true);
            }
            else
            {
                swApp.DisplayStatusBar(false);
            }

            string lang = "";

            if (chklang.Checked == true)
            {
                lang = swApp.GetCurrentLanguage();
                swApp.SendMsgToUser2("languge is: " + lang, 2, 2);
            }
            
        }
    }
}
