using SldWorks;
using SwConst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        SldWorks.SldWorks swApp =   new SldWorks.SldWorks();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnCheckDoc_Click(object sender, EventArgs e)
        {
            SldWorks.ModelDoc2 swModel = null; // = new SldWorks.ModelDoc2();
            SldWorks.PartDoc swPartDoc = null;
            SldWorks.AssemblyDoc swAssemblyDoc = null;
            SldWorks.DrawingDoc swDrawingDoc = null;
            swModel = swApp.ActiveDoc;
            if (swModel.GetType() == (int)swDocumentTypes_e.swDocPART)
            {
                swPartDoc = (PartDoc)swModel;
            }
            if (swModel.GetType() == (int)swDocumentTypes_e.swDocASSEMBLY)
            {
                swAssemblyDoc = (AssemblyDoc)swModel;
            }
            if (swModel.GetType() == (int)swDocumentTypes_e.swDocDRAWING)
            {
                swDrawingDoc = (DrawingDoc)swModel;
            }
            if (swModel.GetType() == (int)swDocumentTypes_e.swDocNONE)
            {
                swApp.SendMsgToUser2("There is no active doc", (int)swMessageBoxIcon_e.swMbStop, (int)swMessageBoxBtn_e.swMbOk);
            }
        }
    }
}
