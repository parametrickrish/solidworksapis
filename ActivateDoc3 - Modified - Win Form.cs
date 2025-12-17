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

            int Errors = 0;
            bool bValue = false;
            int nValue;
            int nRetval;

            // Set user preference to not rebuild on activation
            bValue = swApp.SetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swRebuildOnActivation, (int)swRebuildOnActivation_e.swDontRebuildActiveDoc);
            //Debug.Print("Rebuild user preference set to not rebuild on activation: " + bValue);

            nValue = swApp.GetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swRebuildOnActivation);
            //Debug.Print("swRebuildOnActivation_e user preference is: " + nValue);

            // Ignore the user preference just set
            //Debug.Print("Ignoring rebuild user preference.");

            // Activate the loaded document and prompt for rebuild if the model changed
            swModel = (ModelDoc2)swApp.ActivateDoc3("pillow_block.sldasm", false, (int)swRebuildOnActivation_e.swUserDecision, ref Errors);
            //Debug.Print("Error code after document activation: " + Errors.ToString());
            nRetval = swApp.SendMsgToUser2("Error code after document activation: " + Errors.ToString(), (int)swMessageBoxIcon_e.swMbWarning, (int)swMessageBoxBtn_e.swMbOk);


        }
    }
}
