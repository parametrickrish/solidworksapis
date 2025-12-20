using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnSolidWorks_Click(object sender, EventArgs e)
        {
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            SldWorks.ModelDoc2 swModel = null;
            int errors = 0;

            if (chkLoadFile4.Checked)
            {
                string igsfile = @"C:\Users\Public\Documents\SOLIDWORKS\SOLIDWORKS 2021\samples\tutorial\smartcomponents\bearing.igs";
                swModel = swApp.LoadFile4(igsfile, "", null, errors);
            }

            if (chkCreateNewWindow.Checked)
            {
                swApp.CreateNewWindow();
                swApp.ArrangeWindows(1);
            }
        }
    }
}
