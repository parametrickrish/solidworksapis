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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            MathUtility swMathUtility = swApp.GetMathUtility();
            ModelDoc2 swModel = swApp.ActiveDoc as ModelDoc2;
        }

        public void ParseAssemblyName()
        {
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            ModelDoc2 swModel = swApp.ActiveDoc as ModelDoc2;

            // Get the title first
            string modelTitle = swModel.GetTitle();

            // Split the string using the dot character
            string[] strings = modelTitle.Split('.');
            modelTitle = strings[0];
        }

        private void btnAddComp_Click(object sender, EventArgs e)
        {
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            ModelDoc2 swModel = swApp.ActiveDoc as ModelDoc2;
            if (swModel != null)
            {
                string modelTitle = swModel.GetTitle();
                ParseAssemblyName();
                SelectionMgr swSelMgr;
                swSelMgr = (SelectionMgr)swModel.SelectionManager;
                int SelObjType = 0;
                SelObjType = swSelMgr.GetSelectedObjectType3(1, -1);
                if (SelObjType != (int)swSelectType_e.swSelFACES)
                 { MessageBox.Show("You have not selected face but something else");
                   return;                }
                Face2 swFace = default(Face2);

                swFace = (Face2)swSelMgr.GetSelectedObject6(1, -1);
                SldWorks.Entity swEntity;
                swEntity = (Entity)swFace;
                Entity swSafeEntity = swEntity.GetSafeEntity();
                




            }
        }
    }
}
