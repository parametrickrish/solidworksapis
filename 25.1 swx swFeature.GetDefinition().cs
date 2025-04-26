//--------------------------------------------------------------
// Preconditions:
// 1. Verify that the specified part template exists.
// 2. Open the Immediate window.
//
// Postconditions:
// 1. Opens a new part document.
// 2. Creates a sketch containing sketch contours.
// 3. Creates a boss extrude feature using the sketch of sketch
//    contours.
// 4. Selects the boss extrude feature and accesses
//    its data.
// 5. Gets the sketch contours.
// 6. Get whether each sketch contour is open or closed.
// 7. Examine the FeatureManager design tree, graphics area, and
//    the Immediate window.
//--------------------------------------------------------------
using System;
using System.Diagnostics;
using SldWorks;
//using SolidWorks.Interop.sldworks;
//using SolidWorks.Interop.swconst;
using SwConst;

namespace ExtrudeFeatureData2CSharp.csproj
{
    public static class SolidWorksMacro
    {
        static void Main()
        {
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            ModelDoc2 swModel = swApp.ActiveDoc as ModelDoc2; 

            //ModelDoc2 swModel = default(ModelDoc2);
            SketchManager swSketchMgr = default(SketchManager);
            SketchSegment swSketchSegment = default(SketchSegment);
            ModelDocExtension swModelDocExtension = default(ModelDocExtension);
            SelectionMgr swSelectionMgr = default(SelectionMgr);
            FeatureManager swFeatureMgr = default(FeatureManager);
            Feature swFeature = default(Feature);
            ExtrudeFeatureData2 swExtrudeFeatureData = default(ExtrudeFeatureData2);
            bool status = false;
            object[] skcontours = null;
            SketchContour skcontour = null;
            int nbrContours = 0;
            int i = 0;
            //NewDocument(System.string TemplateName,System.int PaperSize,System.double Width,System.double Height)
            swModel = (ModelDoc2)swApp.NewDocument("C:\\ProgramData\\SolidWorks\\SOLIDWORKS 2021\\templates\\Part.prtdot", 0, 0, 0);
            swModelDocExtension = (ModelDocExtension)swModel.Extension;
            swSketchMgr = (SketchManager)swModel.SketchManager;
            swSelectionMgr = (SelectionMgr)swModel.SelectionManager;
            swFeatureMgr = (FeatureManager)swModel.FeatureManager;

            //Create sketch containing sketch contours
            swSketchMgr.InsertSketch(true);
            swSketchSegment = (SketchSegment)swSketchMgr.CreateCircle(0.0, 0.0, 0.0, 0.010564, -0.041843, 0.0);
            swModel.ClearSelection2(true);
            swSketchSegment = (SketchSegment)swSketchMgr.CreateCircle(0.043155, 0.0, 0.0, 0.048428, -0.01221, 0.0);
            swModel.ClearSelection2(true);
            swSketchSegment = (SketchSegment)swSketchMgr.CreateCircle(-0.043155, 0.0, 0.0, -0.043214, -0.014954, 0.0);
            swModel.ClearSelection2(true);
            swSketchMgr.InsertSketch(true);

            //Create boss extrude feature
            status = swModelDocExtension.SelectByID2("Sketch1", "SKETCH", 0, 0, 0, false, 0, null, 0);
            status = swModelDocExtension.SelectByID2("Sketch1", "SKETCHCONTOUR", -0.047096875714166, 0.00724922083273226, 0.018531938896921, true, 0, null, 0);
            status = swModelDocExtension.SelectByID2("Sketch1", "SKETCHCONTOUR", 0.0473122625955432, -0.015948285832011, -0.0155264330079864, true, 0, null, 0);
            status = swModelDocExtension.SelectByID2("Sketch1", "SKETCHCONTOUR", -0.00880361157802517, -0.0246473508312897, 0.0199951653548178, true, 0, null, 0);
            swModel.ClearSelection2(true);
            swSelectionMgr.EnableContourSelection = true;
            status = swModelDocExtension.SelectByID2("Sketch1", "SKETCH", 0, 0, 0, false, 4, null, 0);
            status = swModelDocExtension.SelectByID2("Sketch1", "SKETCHCONTOUR", -0.047096875714166, 0.00724922083273226, 0.018531938896921, true, 4, null, 0);
            status = swModelDocExtension.SelectByID2("Sketch1", "SKETCHCONTOUR", 0.0473122625955432, -0.015948285832011, -0.0155264330079864, true, 4, null, 0);
            status = swModelDocExtension.SelectByID2("Sketch1", "SKETCHCONTOUR", -0.00880361157802517, -0.0246473508312897, 0.0199951653548178, true, 4, null, 0);
            swFeature = swFeatureMgr.FeatureExtrusion3(false, false, false, 0, 0, 0.01016, 0.01016, false, false, false,
            false, 0.0174532925199433, 0.0174532925199433, false, false, false, false, true, true, true,
            0, 0, false);
            swSelectionMgr.EnableContourSelection = false;

            //Select the boss extrude feature
            status = swModelDocExtension.SelectByID2("Boss-Extrude1", "BODYFEATURE", 0, 0, 0, false, 0, null, (int)swSelectOption_e.swSelectOptionDefault);
            swFeature = (Feature)swSelectionMgr.GetSelectedObject6(1, -1);

            //Access the boss extrude feature data
            swExtrudeFeatureData = (ExtrudeFeatureData2)swFeature.GetDefinition();
            swExtrudeFeatureData.AccessSelections(swModel, null);

            //Get the sketch contours in the feature
            skcontours = (object[])swExtrudeFeatureData.Contours;
            nbrContours = swExtrudeFeatureData.GetContoursCount();
            Debug.Print("Number of sketch contours in this extrude feature: " + nbrContours);

                        //Get the sketch contours in the extrude feature
            skcontours = (object[])swExtrudeFeatureData.Contours;

            //Get each sketch contour and whether it is open or closed
            for (i = 0; i <= (nbrContours - 1); i++)
            {
                skcontour = (SketchContour)skcontours[i];
                Debug.Print("  Sketch contour " + i + " is closed? " + skcontour.IsClosed());
            }

            //Releases selection access
            swExtrudeFeatureData.ReleaseSelectionAccess();

        }

        /// <summary>
        /// The SldWorks swApp variable is pre-assigned for you.
        /// </summary>

        //public SldWorks swApp;

    }
}