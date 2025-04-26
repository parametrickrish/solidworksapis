using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using SldWorks;
using SwConst;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                            
                //connect to solidworks application
                SldWorks.SldWorks swApp = new SldWorks.SldWorks();
                ModelDoc2 swModel = swApp.ActiveDoc as ModelDoc2;
                bool booleanstatus = false;

                //select front plane
                booleanstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
                swModel.SketchManager.InsertSketch(true);

                //creating line
                SldWorks.SketchSegment skSegment;
                skSegment = swModel.SketchManager.CreateLine(0, 0, 0, 0.05, 0.04, 0);
                swModel.SketchManager.InsertSketch(true);

                //select sketch
                booleanstatus = swModel.Extension.SelectByID2("Sketch1", "SKETCH", 0, 0, 0, false, 4, null, 0);
                double d1 = 0.025;
                //create extrude thin feature
                Feature myfeature;
                myfeature = swModel.FeatureManager.FeatureExtrusionThin2(false, false, false, 0, 0, d1, d1, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, 0.01, 0.01, 0.01, 0, 0, false, 0.005, true, true, 0, 0, false);
                //swModel.SelectionManager.EnableContourSelection = false;
        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            //connect to solidworks application
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            ModelDoc2 swModel = swApp.ActiveDoc as ModelDoc2;
            bool booleanstatus = false;

            //select front plane
            booleanstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);

            //creating line
            SldWorks.SketchSegment skSegment;
            skSegment = swModel.SketchManager.CreateLine(0, 0, 0, 0.05, 0.04, 0);
            swModel.SketchManager.InsertSketch(true);

            //select sketch
            booleanstatus = swModel.Extension.SelectByID2("Sketch1", "SKETCH", 0, 0, 0, false, 4, null, 0);
            double d1 = 0.035;
            //create extrude thin feature
            Feature myfeature;
            myfeature = swModel.FeatureManager.FeatureExtrusionThin2(false, false, false, 0, 0, d1, d1, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, 0.01, 0.01, 0.01, 0, 0, false, 0.005, true, true, 0, 0, false);
            //swModel.SelectionManager.EnableContourSelection = false;
        }
    }
    }

