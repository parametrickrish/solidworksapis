using sldworks;
using SldWorks;
using swconst;
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
                ModelDoc2 Part = swApp.ActiveDoc;
                bool boolstatus = false;

                if (Part != null)
                { }

                boolstatus = Part.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);

                Part.SketchManager.InsertSketch(true);

                object skSegment = Part.SketchManager.CreateCircle(0.0, 0.0, 0.0, -0.024665, 0.011824, 0.0);

                Part.SketchManager.InsertSketch(true);

                Feature myFeature = Part.FeatureManager.FeatureExtrusion2(true, false, false,
                                                                          (int)swStartConditions_e.swStartSketchPlane, 0, // No specific start condition needed for 'From Sketch Plane'
                                                                          0.015, 0.01, false, false, false, false,
                                                                          1.74532925199433E-02, 1.74532925199433E-02,
                                                                          false, false, false, false, true, true, true, 0, 0, false);



            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) //btnBuild click event
        {
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            ModelDoc2 swModel;
            string parttemplate = "";
            parttemplate = swApp.GetUserPreferenceStringValue((int)swUserPreferenceStringValue_e.swDefaultTemplatePart);

            //new part document
            swModel = (ModelDoc2)swApp.NewDocument(parttemplate, 0, 0, 0);

            swModel.SketchManager.AddToDB = true;

            swModel.SetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swUnitsLinear, (int)swLengthUnit_e.swMM);

            swModel.SketchManager.AddToDB = false;
        }
    }
    }



   
