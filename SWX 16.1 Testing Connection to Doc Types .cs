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
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        SldWorks.SldWorks swApp = new SldWorks.SldWorks();
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

        private void btnModel_Click(object sender, EventArgs e)
        {
            //SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            SldWorks.ModelDoc2 swModel = null; // = new SldWorks.ModelDoc2();

           
            string DocTemp = "C:\\ProgramData\\SolidWorks\\SOLIDWORKS 2021\\templates\\";
            SldWorks.View swView;

            if (rbtnpart.Checked)
            { 
            swModel = swApp.NewDocument(DocTemp + "Part.PRTDOT", 0,0,0);
            }

            if (rbtnasm.Checked)
            {
                swModel = swApp.NewDocument(DocTemp + "Assembly.ASMDOT", 0, 0, 0);
            }

            if (rbtndrw.Checked)
            {
                swModel = swApp.NewDocument(DocTemp + "Drawing.DRWDOT", 0, 0, 0);
            }

            if (chkinsertksetch.Checked)
            {
                if (!rbtndrw.Checked)
                {
                    
                    swModel.SketchManager.InsertSketch(true);
                }
                else
                {
                    swView = PrepareDrawingView(ref swModel);
                    swView.FocusLocked = true;
                }
               
            }

            if (chkinsertable.Checked)
            {
                if (!rbtndrw.Checked)
                {
                   
                    swModel.InsertFamilyTableNew();
                        }
                else
                {
                    swView = PrepareDrawingView(ref swModel);
                    swModel.Extension.SelectByID2(swView.GetName2(), "DRAWING", 0, 0, 0, false, 0, null, 0);
                }
                
            }

            if (chkinsertnote.Checked)
            {
                SldWorks.Note swNote;
                SldWorks.Annotation swAnnoation;
                string text;

                text = "Sample Note As a SWX Developer";
                swNote = swModel.InsertNote(text);
                swAnnoation = swNote.GetAnnotation();
                swAnnoation.SetPosition2(0.02, 0.02, 0);
            }
        }

        private void chkeditrollback_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public SldWorks.View PrepareDrawingView(ref ModelDoc2 swModel)
        {
            DrawingDoc swDrawing;
            swDrawing = (DrawingDoc)swModel;
            string drwName = swModel.GetTitle();
            int errors = 0;
            int warning = 0;

            //open the part
            string filedir = @"C:\Users\Public\Documents\SOLIDWORKS\SOLIDWORKS 2021\samples\tutorial\smartcomponents\bearing.sldprt";

            swApp.OpenDoc6(filedir, (int)swDocumentTypes_e.swDocPART, (int)swOpenDocOptions_e.swOpenDocOptions_LoadModel,"",ref errors,ref warning);

            swApp.ActivateDoc2(drwName, true, ref errors);

            //create the drawing view
            SldWorks.View drwView = swDrawing.CreateDrawViewFromModelView3(filedir, "*Isometric", 0.1, 0.1, 0);

            return drwView;

        }

        private void btnnewpart_Click(object sender, EventArgs e)
        {
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            SldWorks.ModelDoc2 swModel = null;
            string DocTemp = "C:\\ProgramData\\SolidWorks\\SOLIDWORKS 2021\\templates\\";
            swModel = swApp.NewDocument(DocTemp + "Part.PRTDOT", 0, 0, 0);
            SldWorks.PartDoc swPartDoc = null;
            swPartDoc = (PartDoc)swModel;
            swModel.SketchManager.InsertSketch(true);
            swModel.SketchManager.CreateCornerRectangle(0, 0, 0, 0.15, 0.15, 0);
            swModel.FeatureManager.FeatureExtrusion3(true, false, true, (int)swEndConditions_e.swEndCondBlind, 0, 0.003, 0.003, false, false, false,
            false, 0.0174532925199433, 0.0174532925199433, false, false, false, false, true, true, true,
            (int)swStartConditions_e.swStartSketchPlane, 0, false);
            swModel.SketchManager.InsertSketch(true);
            if (chkeditrollback.Checked)
            {
                swPartDoc.EditRollback();
            }
        }

        private void btnnewassembly_Click(object sender, EventArgs e)
        {
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            SldWorks.ModelDoc2 swModel = null;
            int errors = 0;
            int warning = 0;
            SldWorks.AssemblyDoc swAssemblyDoc = null;
            string filedir = @"C:\Users\Public\Documents\SOLIDWORKS\SOLIDWORKS 2021\samples\tutorial\smartcomponents\pillow_block.sldasm";
            string DocTemp = "C:\\ProgramData\\SolidWorks\\SOLIDWORKS 2021\\templates\\";
            swApp.OpenDoc6(filedir, (int)swDocumentTypes_e.swDocASSEMBLY, (int)swOpenDocOptions_e.swOpenDocOptions_LoadModel, "", ref errors, ref warning);
            swModel = swApp.NewDocument(DocTemp + "Assembly.ASMDOT", 0, 0, 0);
            swAssemblyDoc = (AssemblyDoc)swModel;

            if (chkaddcomp.Checked)
                {
                swAssemblyDoc.AddComponent5(@"C:\Users\Public\Documents\SOLIDWORKS\SOLIDWORKS 2021\samples\tutorial\smartcomponents\bearing.sldprt", (int)swAddComponentConfigOptions_e.swAddComponentConfigOptions_CurrentSelectedConfig, "", false, "", 0, 0, 0);
                }
        }

        private void btnnewdrawing_Click(object sender, EventArgs e)
        {
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            SldWorks.ModelDoc2 swModel = null;
            SldWorks.DrawingDoc swDrawingDoc = null;
            
            string DocTemp = "C:\\ProgramData\\SolidWorks\\SOLIDWORKS 2021\\templates\\";
            swModel = swApp.NewDocument(DocTemp + "Drawing.DRWDOT", 0, 0, 0);
            swDrawingDoc = (DrawingDoc)swModel;

            if (chkeditofrmat.Checked) { swDrawingDoc.EditTemplate(); }
        }
    }
}
