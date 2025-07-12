using SldWorks;
using SwConst;
using SwCommands; //optional
using System;

namespace SolidWorksMacro
{
    public class SwMacro
    {
        public void Main()
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
    }
}