using System;
using SldWorks;
using SwConst;

namespace firstprogram
{
    public static class createlineandextrudethin
    {
        static void Main(string[] args)
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

            //create extrude thin feature
            Feature myfeature;
            myfeature = swModel.FeatureManager.FeatureExtrusionThin2(true, false, false, 0, 0, 0.01, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, 0.01, 0.01, 0.01, 0, 0, false, 0.005, true, true, 0, 0, false);
            //swModel.SelectionManager.EnableContourSelection = false;
        }
    }
}