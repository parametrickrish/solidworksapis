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
            //Part = (ModelDoc2)swApp.NewDocument("C:\\ProgramData\\SOLIDWORKS\\SOLIDWORKS  2017\ emplates\\Part.prtdot", 0, 0, 0);


            //new part document
           swModel = (ModelDoc2)swApp.NewDocument(parttemplate, 0, 0, 0);

            swModel.SketchManager.AddToDB = true;

            swModel.SetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swUnitsLinear, (int)swLengthUnit_e.swMM);

            PartDoc swPart = (PartDoc)swModel;

            if (rbtnBrass.Checked ==true )
            {
                swPart.SetMaterialPropertyName2("", "", "Brass");
            }

            if (rbtnAL.Checked == true)
            {
                swPart.SetMaterialPropertyName2("", "", "1060-H12 Rod (SS)");
            }

            bool boolstat;
            boolstat = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);

            double height, width;
            double radius = 0;
            double depth = 0;
            height = double.Parse(txtHeight.Text) / 1000;
            width = double.Parse(txtWidth.Text) / 1000;

            if (rbtnRectangle.Checked == true)
            {
                //height = double.Parse(txtHeight.Text) / 1000;
                //width = double.Parse(txtWidth.Text) / 1000;

                //Unsuppress the dimension dialog box
                swApp.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swInputDimValOnCreate, false);

                SldWorks.SketchSegment SketchSegmentObj;
                SketchSegmentObj = swModel.SketchManager.CreateLine(0.05, 0.05, 0, 0.05, 0.05 + height, 0);
                swModel.AddDimension2(0, 0.05 + height / 2, 0);

                swModel.SketchManager.CreateLine(0.05, 0.05 + height, 0, 0.05 + width, 0.05 + height, 0);
                swModel.SketchManager.CreateLine(0.05 + width, 0.05 + height, 0, 0.05 + width, 0.05, 0);
                swModel.SketchManager.CreateLine(0.05 + width, 0.05, 0, 0.05, 0.05, 0);
                swModel.AddDimension2(0.05 + width / 2, 0, 0);
                swModel.ClearSelection2(true);

                //select the origin
                swModel.Extension.SelectByID2("", "EXTSKETCHPOINT", 0, 0, 0, false, 0, null, 0);
                //select an endpoint on profile
                swModel.Extension.SelectByID2("", "SKETCHPOINT", 0.05, 0.05, 0, true, 0, null, 0);
                //add a verticle dimension
                swModel.AddVerticalDimension2(0, 0.025, 0);
                swModel.ClearSelection2(true);

                //select the origin
                swModel.Extension.SelectByID2("", "EXTSKETCHPOINT", 0, 0, 0, false, 0, null, 0);
                //select an endpoint on profile
                swModel.Extension.SelectByID2("", "SKETCHPOINT", 0.05, 0.05, 0, true, 0, null, 0);
                //add a verticle dimension
                swModel.AddHorizontalDimension2(0.025, 0, 0);
                swModel.ClearSelection2(true);

                SelectionMgr swSelMgr = (SelectionMgr)swModel.SelectionManager;
                SelectData swSelData = (SelectData)swSelMgr.CreateSelectData();
                boolstat = SketchSegmentObj.Select4(true, swSelData);

                if (boolstat == false)
                { MessageBox.Show("Failed to select sketch segment for offset."); }
                //create offset from selected edge
                swModel.SketchOffset2(0.002, false, true);
                swModel.ViewZoomtofit2();
                
            }

            if (rbtnCircle.Checked == true)
            {
                radius = double.Parse(txtRadius.Text) / 1000;
                swModel.SketchManager.CreateCircleByRadius(0.05 + radius, 0.05 + radius, 0, radius);
                swModel.SketchOffset2(0.002, false, true);
                swModel.ViewZoomtofit2();
            }

            if (rbtnRevolve.Checked == true)
            {
                swModel.SketchManager.CreateLine(0, 0, 0, 0, 0.05, 0).ConstructionGeometry = true;
                swModel.ViewZoomtofit2();
            }

            swModel.SketchManager.AddToDB = false;


            SldWorks.FeatureManager swFeatureMgr;
            if (rbtnExtrude.Checked== true)
            {
                depth = double.Parse(txtDepth.Text) / 1000;
                swFeatureMgr = swModel.FeatureManager;

                if (rbtnRectangle.Checked == true)

                {
                    if (chkContour1.Checked == true)
                    {
                        // Enable contour selection
                        ((SelectionMgr)(swModel.SelectionManager)).EnableContourSelection = true;
                        // Select a contour to extrude
                        swModel.Extension.SelectByID2("Sketch1", "SKETCHREGION", 0.05 + (width/2), 0.05 + (height/2), 0, true, 4, null, 0);
                    }
                    if (chkContour2.Checked == true)
                    {
                        // Enable contour selection
                        ((SelectionMgr)(swModel.SelectionManager)).EnableContourSelection = true;
                        // Select a contour to extrude
                        swModel.Extension.SelectByID2("Sketch1", "SKETCHREGION", 0.049, 0.049, 0, true, 4, null, 0);
                    }
                }
                else //circle selected
                {
                    if (chkContour1.Checked == true)
                    {
                        // Enable contour selection
                        ((SelectionMgr)(swModel.SelectionManager)).EnableContourSelection = true;
                        // Select a contour to extrude
                        swModel.Extension.SelectByID2("Sketch1", "SKETCHREGION", 0.06, 0.06, 0, true, 4, null, 0);
                    }
                    if (chkContour2.Checked == true)
                    {
                        // Enable contour selection
                        ((SelectionMgr)(swModel.SelectionManager)).EnableContourSelection = true;
                        // Select a contour to extrude
                        swModel.Extension.SelectByID2("Sketch1", "SKETCHREGION", 0.06, 0.06, 0, true, 4, null, 0);
                    }
                }

                // Extrusion parameters: Blind end condition, Start from Sketch Plane, no draft
                swFeatureMgr.FeatureExtrusion3(
    true,                                   // Sd: Single ended
    false,                                  // Flip: Direction (false = normal)
    false,                                  // Dir: Extrude normal to sketch
    (int)swEndConditions_e.swEndCondBlind,  // Term1: End condition (Blind)
    0,                                      // Term2: End condition Dir 2 (Ignored)
    depth,                                  // D1: Depth in meters
    0,                                      // D2: Depth Dir 2 (Ignored)
    false,                                  // Dchk1: Draft for Dir 1
    false,                                  // Dchk2: Draft for Dir 2
    false,                                  // Dopt1: Draft outward Dir 1
    false,                                  // Dopt2: Draft outward Dir 2
    0,                                      // Din1: Draft angle Dir 1
    0,                                      // Din2: Draft angle Dir 2
    false,                                  // UseDR1: Use Draft for Dir 1
    false,                                  // UseDR2: Use Draft for Dir 2
    false,                                  // UseUV1: Use UV for Dir 1
    false,                                  // UseUV2: Use UV for Dir 2
    false,                                  // Mono: Modify other direction
    true,                                   // Sol: Result as solid body
    true,                                   // Topo: Optimize geometry
    (int)swStartConditions_e.swStartSketchPlane, // StartCond: Start from sketch plane
    0,                                      // StartOff: Start offset (Ignored)
    false                                   // FlipStart: Flip start direction
);
                ((SelectionMgr)(swModel.SelectionManager)).EnableContourSelection = false;
                swModel.ViewZoomtofit2();


            }
            else
            {
                double pi = 3.142;
                double angle;
                angle = double.Parse(txtAngle.Text);
                angle = angle * pi / 180;
                swFeatureMgr = swModel.FeatureManager;
                swFeatureMgr.FeatureRevolve2(true, true, false, false, false, false, 0, 0, angle, 0, false,
            false, 0, 0, 0, 0, 0, true, true, true);
            }


        }


        private void rbtnRevolve_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDepth_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkContour1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }



   
