using SldWorks;
using SwConst;
using System;

using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            ModelDoc2 swModel = swApp.ActiveDoc as ModelDoc2;
            bool booleanstatus;
            //select front plane
            booleanstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);

            double p1x,p1y,p2x,p2y,p3x,p3y,p4x,p4y;
            double length, width;
            length = 0.04;
            width = 0.025;
            
            p1x = 0; p1y = 0;
            p2x = p1x + length; p2y = p1y;
            p3x = p1x + length; p3y = p1y + width;
            p4x = p1x;p4y = p1y + width;


            //creating line
            SldWorks.SketchSegment skSegment;
            skSegment = swModel.SketchManager.CreateLine(p1x, p1y, 0, p2x, p2y, 0);
            skSegment = swModel.SketchManager.CreateLine(p2x, p2y, 0, p3x, p3y, 0);
            skSegment = swModel.SketchManager.CreateLine(p3x, p3y, 0, p4x, p4y, 0);
            skSegment = swModel.SketchManager.CreateLine(p4x, p4y, 0, p1x, p1y, 0);
            swModel.SketchManager.InsertSketch(true);

            //select sketch
            //booleanstatus = swModel.Extension.SelectByID2("Sketch1", "SKETCH", 0, 0, 0, false, 4, null, 0);

            //create extrude thin feature
            Feature myfeature;
            myfeature = swModel.FeatureManager.FeatureExtrusion3(false, false, true, 0, 0, 0.01, 0.01, false, false,
                false, false, 0.0, 0.0, false, false, false, false, false, false, true, 0,
                0.0, false);

        }
    }
}
