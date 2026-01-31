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

namespace Assembly_Automation_1
{
    public partial class Form1 : Form
    {
        private SldWorks.SldWorks swApp;
        private ModelDoc2 swModel;
        private MathUtility swMathUtility;
        string modelTitle = "";
        private Entity swSafeEntity;
        SelectionMgr swSelMgr;
        private Face2 swFace;
        private MathTransform swCompTransform;
        private SldWorks.AssemblyDoc swAssy;
        List<Edge> circularEdgeCollection = new List<Edge>();
        List<Curve> circularCurveCollection = new List<Curve>();
        List<Face2> SafeCylindricalFaceCollection = new List<Face2>();
        // List<Entity> SafeCylindricalFaceCollection = new List<Entity>();
        List<MathPoint> PointCollection = new List<MathPoint>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            swApp = new SldWorks.SldWorks();
            swMathUtility = swApp.GetMathUtility();
            swModel = (ModelDoc2)swApp.ActiveDoc;
        }

        public void ParseAssemblyName()
        {
            if (swModel == null) swModel = (ModelDoc2)swApp.ActiveDoc;

            // Get the title first
            modelTitle = swModel.GetTitle();

            // Split the string using the dot character
            string[] strings = modelTitle.Split('.');
            modelTitle = strings[0];
        }

        public void btnAddComp_Click(object sender, EventArgs e)
        {
            swModel = (ModelDoc2)swApp.ActiveDoc;
            if (swModel != null)
            {
                ParseAssemblyName();
                
                swSelMgr = (SelectionMgr)swModel.SelectionManager;
                int SelObjType = 0;
                SelObjType = swSelMgr.GetSelectedObjectType3(1, -1);
                if (SelObjType != (int)swSelectType_e.swSelFACES)
                 { MessageBox.Show("You have not selected face but something else");
                   return;                }
                Face2 swFace = default(Face2);

                swFace = (Face2)swSelMgr.GetSelectedObject6(1, -1);
                Entity swEntity = (Entity)swFace;
                 swSafeEntity = swEntity.GetSafeEntity();
                
            }

            //we will break the actions into multiple small actions
            //establish target components transform
            //open components model to add to assembly
            // establish circular curve and edge collections
            // establish cylindrical face collection
            //establish points collection
            //add components to assembly
            // finalization

        }

        public void EstablishTargetComponentsTransform()
        {
            Component2 swComponent = swSafeEntity.GetComponent();
            swCompTransform = swComponent.Transform2;

        }

        public void OpenComponentModelToAddToAsm(string strCompModelName)
        {
            int longstatus = 0;
            int longwarnings = 0; 
            swApp.DocumentVisible(false, (int)swDocumentTypes_e.swDocPART);
            swApp.OpenDoc6(strCompModelName, (int)swDocumentTypes_e.swDocPART, 
                (int)swOpenDocOptions_e.swOpenDocOptions_Silent,"", ref longstatus, ref longwarnings);
            
            swModel = swApp.ActivateDoc3(modelTitle, false, (int)swRebuildOnActivation_e.swDontRebuildActiveDoc, ref longstatus);

            swAssy = (SldWorks.AssemblyDoc)swModel;
        }
        public void EstablishCircularCurveAndEdgeCollections()
        {
            SldWorks.Loop2 swLoop;
            swLoop = swFace.GetFirstLoop();

            while (swLoop != null)
            {
                if (!swLoop.IsOuter())
                {
                    object[] swEdges = (object[])swLoop.GetEdges();

                    if (swEdges !=null)
                    {
                        foreach (object objEdge in swEdges)
                        {
                            SldWorks.Edge swEdge = (Edge)objEdge;
                            Curve swCurve = (Curve)swEdge.GetCurve();

                            if (swCurve.IsCircle())
                            {
                                circularEdgeCollection.Add(swEdge);
                                circularCurveCollection.Add(swCurve);
                            }
                        }
                    }
                }
                // Move to the next loop in the face
               swLoop = (Loop2)swLoop.GetNext();
            }

        }
        public void EstablishCircularFaceCollection()
        {
            foreach (Edge swEdge in circularEdgeCollection)
            {
                object[] swFaces = (object[])swEdge.GetTwoAdjacentFaces2();

                if (swFaces != null && swFaces.Length == 2)
                        {
                    Face2 swFace1 = (Face2)swFaces[0];
                    Face2 swFace2 = (Face2)swFaces[1];

                    Surface swSurface1 = (Surface)swFace1.GetSurface();
                    Surface swSurface2 = (Surface)swFace2.GetSurface();

                    Entity swEntity = null;
                    // Determine which one is the cylindrical surface
                    if (swSurface1.IsCylinder())
                    {
                        swEntity = (Entity)swFace1;
                    }
                    else if (swSurface2.IsCylinder())
                    {
                        swEntity = (Entity)swFace2;
                    }
                    // When the cylindrical Face is found...
                    if (swEntity != null)
                    {
                        Entity swSafeFace = swEntity.GetSafeEntity();
                        SafeCylindricalFaceCollection.Add((Face2)swSafeFace);
                    }
                }
            }
        }

        public void EstablishPointsCollection()

        {
            foreach (Curve swCurve in circularCurveCollection)
            {
                // circleParams returns: [Center x, y, z, Axis x, y, z, Radius]
                double[] circleParams = (double[])swCurve.CircleParams;

                // Extract Center Point coordinates (indices 0, 1, 2)
                double[] arrayData = new double[3];
                arrayData[0] = circleParams[0];
                arrayData[1] = circleParams[1];
                arrayData[2] = circleParams[2];

                // Create a MathPoint object
                MathPoint swMathPoint = (MathPoint)swMathUtility.CreatePoint(arrayData);

                // Transform the point from local component space to Assembly space
                // This ensures the component is placed in the correct location in the ASM
                swMathPoint = (MathPoint)swMathPoint.MultiplyTransform(swCompTransform);

                PointCollection.Add(swMathPoint);
            }
        }

        public void AddComponentsToAssembly(string strCompFullPath)
        {
            AssemblyDoc swAssy = (AssemblyDoc)swModel;
            string assemblyName = swModel.GetTitle().Split('.')[0];

            

                // --- MATE 1: COINCIDENT ---
                swModel.ClearSelection2(true);
                // Select the original face we started with (stored in swSafeEntity/swSafeSelFace)
                swSafeEntity.Select4(true, selData);
                // Select the "Top" plane of the NEW component
                swModel.Extension.SelectByID2("Top@" + strCompName + "@" + assemblyName, "PLANE", 0, 0, 0, true, 1, null, 0);

                swAssy.AddMate3((int)swMateType_e.swMateCOINCIDENT, (int)swMateAlign_e.swMateAlignCLOSEST, false, 0, 0, 0, 0, 0, 0, 0, 0, false, out int errors);

                // --- MATE 2: CONCENTRIC ---
                swModel.ClearSelection2(true);
                // Select the cylindrical face of the hole
                SafeCylindricalFaceCollection[j].Select4(true, selData);
                // Select the Origin/Point of the NEW component
                swModel.Extension.SelectByID2("Point1@Origin@" + strCompName + "@" + assemblyName, "EXTSKETCHPOINT", 0, 0, 0, true, 1, null, 0);

                swAssy.AddMate3((int)swMateType_e.swMateCONCENTRIC, (int)swMateAlign_e.swMateAlignCLOSEST, false, 0, 0, 0, 0, 0, 0, 0, 0, false, out errors);

            }

        }


    }
}
