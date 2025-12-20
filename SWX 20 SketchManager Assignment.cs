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

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        SldWorks.SldWorks swApp = new SldWorks.SldWorks();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsldworks_Click(object sender, EventArgs e)
        {
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            SldWorks.ModelDoc2 swModel = null;
            swModel = (ModelDoc2)swApp.ActiveDoc;


            if (swModel == null)
            {
                swApp.SendMsgToUser2("Please open a doc", 2, 2);
                return;
            }
        }

        private void btnmodeldoc2_Click(object sender, EventArgs e)
        {
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            SldWorks.ModelDoc2 swModel = null;
            swModel = (ModelDoc2)swApp.ActiveDoc;

            if (chkPart.Checked)
            {
                string DocTemp = "C:\\ProgramData\\SolidWorks\\SOLIDWORKS 2021\\templates\\";
                swModel = swApp.NewDocument(DocTemp + "Part.PRTDOT", 0, 0, 0);
                
                SldWorks.PartDoc swPartDoc = null;
                swPartDoc = (PartDoc)swModel;

                if (swPartDoc == null)
                {
                    swApp.SendMsgToUser2("Please open a part", 2, 2);
                    return;
                }

                swModel.SketchManager.InsertSketch(true);
                swModel.SketchManager.CreateCircleByRadius(0, 0, 0, 0.25);
                swModel.SketchManager.InsertSketch(true);
                swModel.ViewZoomtofit2();

            }

            if (chkAssembly.Checked)
            {
                SldWorks.AssemblyDoc swAssemblyDoc = null;
                
                string DocTemp = "C:\\ProgramData\\SolidWorks\\SOLIDWORKS 2021\\templates\\";
                
                swModel = swApp.NewDocument(DocTemp + "Assembly.ASMDOT", 0, 0, 0);
                swAssemblyDoc = (AssemblyDoc)swModel;

                if (swAssemblyDoc == null)
                {
                    swApp.SendMsgToUser2("Please open an assembly", 2, 2);
                    return;
                }

                swModel.SketchManager.InsertSketch(true);
                swModel.SketchManager.CreateCircleByRadius(0, 0, 0, 0.25);
                swModel.SketchManager.InsertSketch(true);
                swModel.ViewZoomtofit2();

            }




        }
    }
}
