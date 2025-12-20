using SldWorks;
using SwConst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

        private void btnConnectToModel_Click(object sender, EventArgs e)
        {
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            SldWorks.ModelDoc2 swModel = null;
            swModel = (ModelDoc2)swApp.ActiveDoc;
           
            if (swModel == null)
            {
                swApp.SendMsgToUser2("Please open a part or asm or drw", 2, 2);
                return;
            }

            if (chkSetToolbarVis.Checked)
            {
                swModel.SetToolbarVisibility((int)swToolbar_e.swFeatureToolbar, true);
                swModel.SetToolbarVisibility((int)swToolbar_e.swMacroToolbar, true);
                swModel.SetToolbarVisibility((int)swToolbar_e.swMainToolbar, true);
            }
            else
            {
                swModel.SetToolbarVisibility((int)swToolbar_e.swFeatureToolbar, false);
                swModel.SetToolbarVisibility((int)swToolbar_e.swMacroToolbar, false);
                swModel.SetToolbarVisibility((int)swToolbar_e.swMainToolbar, false);
            }

            if (chkAddCustomProp.Checked)
            {
                CustomPropertyManager cusPropMgr;
                Configuration config;
                config = (Configuration)swModel.GetActiveConfiguration();
                cusPropMgr = config.CustomPropertyManager;
                int lRetVal;

                lRetVal = cusPropMgr.Add3("ADATE", (int)swCustomInfoType_e.swCustomInfoDate, "4-13-25", (int)swCustomPropertyAddOption_e.swCustomPropertyDeleteAndAdd);

            }
        }

        private void btnexistingpart_Click(object sender, EventArgs e)
        {
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            SldWorks.ModelDoc2 swModel = null;
            swModel = (ModelDoc2)swApp.ActiveDoc;

            if (swModel == null)
            {
                swApp.SendMsgToUser2("Please open a part", 2, 2);
                return;
            }

            SldWorks.PartDoc swPartDoc = null;
            swPartDoc = (PartDoc)swModel;

            if (chkMirrorPart.Checked)
            {
                bool boolstat;
                boolstat = swModel.Extension.SelectByID2("top", "PLANE", 0, 0, 0, false, 0, null, 0);

                swPartDoc.MirrorPart();

                swModel = (ModelDoc2)swApp.ActiveDoc;
                swModel.ShowNamedView2("*Isometric", 7);
                swModel.ViewZoomtofit2();
                swApp.ArrangeWindows(1);
                bool retval;
                int errors = 0;

                swModel = swApp.ActivateDoc2("bearing.sldprt", true, errors);

                retval = swModel.DeSelectByID("top", "PLANE", 0, 0, 0);

            }

        }

        private void btnexistingasm_Click(object sender, EventArgs e)
        {
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            SldWorks.ModelDoc2 swModel = null;
            swModel = (ModelDoc2)swApp.ActiveDoc;

            SldWorks.AssemblyDoc swAsmDoc = null;
            swAsmDoc = (AssemblyDoc)swModel;


            if (swAsmDoc == null)
            {
                swApp.SendMsgToUser2("Please open a assembly", 2, 2);
                return;
            }

                       
            if (chkInsertCAvity.Checked)
                {
                bool boolstat;
                boolstat = swModel.Extension.SelectByID2("bearing-1@pillow_block", "COMPONENT", 0, 0, 0, false, 0, null, 0);
                int info = 0;
                long retval;
                retval = swAsmDoc.EditPart2(true, false, (int)info);
                swModel.ClearSelection2(true);
                boolstat=swModel.Extension.SelectByID2("flatwasher-1@pillow_black", "COMPONENT", 0, 0, 0, true, 0, null, 0);
                swAsmDoc.InsertCavity4(0.0, 0, 0.0, true, 1, -1);
                swAsmDoc.EditAssembly();
                boolstat=swModel.Extension.SelectByID2("flatwasher-1@pillow_black", "COMPONENT", 0, 0, 0, true, 0, null, 0);
                swModel.EditSuppress2();

            }
        }

        private void btnExistingDrawing_Click(object sender, EventArgs e)
        {
            
        }
    }
}
