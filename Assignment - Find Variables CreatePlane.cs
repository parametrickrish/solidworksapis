using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Runtime.InteropServices;
using System;

namespace Create3DSketchPlaneCSharp.csproj
{
    public partial class SolidWorksMacro
    {
        public void Main()
        {
            ModelDoc2 swModel = default(ModelDoc2);
            ModelDocExtension swModelDocExt = default(ModelDocExtension);
            SketchManager swSketchManager = default(SketchManager);
            SketchSegment swSketchSegment = default(SketchSegment);
            Sketch swSketch = default(Sketch);
            bool status = false;

            //Open new part document
            swModel = (ModelDoc2)swApp.NewDocument("C:\\ProgramData\\SolidWorks\\SolidWorks 2015\ emplates\\Part.prtdot", 0, 0, 0);

            //Insert 3D sketch of  two lines
            swSketchManager = (SketchManager)swModel.SketchManager;
            swSketchManager.Insert3DSketch(true);
            swSketchSegment = (SketchSegment)swSketchManager.CreateCenterLine(-0.082642, 0.005659, 0.0, -0.049926, 0.045073, 0.0);
            swSketch = (Sketch)swSketchManager.ActiveSketch;
            status = swSketch.SetWorkingPlaneOrientation(0, 0, 0, 0, 1, 0, 0, 0, 1, 1,
            0, 0);
            swSketchSegment = (SketchSegment)swSketchManager.CreateCenterLine(-0.049926, 0.045073, 0.0, -0.049926, -0.022634, -0.065874);
            swSketch = (Sketch)swSketchManager.ActiveSketch;
            status = swSketch.SetWorkingPlaneOrientation(0, 0, 0, 0, 0, 1, 1, 0, 0, 0,
            1, 0);
            swModel.ClearSelection2(true);
            swSketchManager.InsertSketch(true);

            //Insert 2D sketch of a circle
            swModel.ActivateSelectedFeature();
            swModel.ClearSelection2(true);
            swSketchManager.InsertSketch(true);
            swModelDocExt = (ModelDocExtension)swModel.Extension;
            status = swModelDocExt.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            swSketchSegment = (SketchSegment)swSketchManager.CreateCircle(-0.056401, 0.005985, 0.0, -0.054697, -0.005141, 0.0);
            swModel.ClearSelection2(true);
            swSketchManager.InsertSketch(true);
            swModel.ClearSelection2(true);

            //Insert a 3D sketch plane
            swSketchManager.Insert3DSketch(true);
            status = swModelDocExt.SelectByID2("Line1@3DSketch1", "EXTSKETCHSEGMENT", -0.0565609614209999, 0.0370796232466087, 0, true, 0, null, 0);
            status = swModelDocExt.SelectByID2("Point2@Sketch1", "EXTSKETCHPOINT", -0.0564010297276809, 0.00598490302365917, 0, true, 0, null, 0);
            status = swSketchManager.CreateSketchPlane(9, 9, 0);
            status = swModelDocExt.SelectByID2("Plane1", "SKETCHSURFACES", 0, 0, 0, false, 0, null, 0);
            swModel.ActivateSelectedFeature();
            swModel.ClearSelection2(true);
            swSketchManager.InsertSketch(true);

        }

        /// <summary>
        ///  The SldWorks swApp variable is pre-assigned for you.
        /// </summary>
        public SldWorks swApp;
    }
}
