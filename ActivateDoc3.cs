//----------------------------------------------------------------------------
// Preconditions:
// 1. Open an assembly.
// 2. Replace loaded_document with the assembly name.
// 3. Right-click a part in the FeatureManager design tree.
// 4. Select Open Part from the toolbar.
// 5. Edit a feature in the part.
// 6. Click OK in the PropertyManager to accept the changes.
//
// Postconditions:
// 1. Displays a dialog.
// 2. Click Yes to rebuild the assembly.
// 3. Activates the assembly document.
// 4. Inspect the Immediate Window.
---------------------------------------------------------------------------

using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Runtime.InteropServices;

namespace Macro1CSharp.csproj
{
    partial class SolidWorksMacro
    {
        ModelDoc2 swModel;
        int Errors;
        bool bValue = false;
        int nValue;

        public void Main()
        {
            // Set user preference to not rebuild on activation
            bValue = swApp.SetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swRebuildOnActivation, (int)swRebuildOnActivation_e.swDontRebuildActiveDoc);
            Debug.Print("Rebuild user preference set to not rebuild on activation: " + bValue);

            nValue = swApp.GetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swRebuildOnActivation);
            Debug.Print("swRebuildOnActivation_e user preference is: " + nValue);

            // Ignore the user preference just set
            Debug.Print("Ignoring rebuild user preference.");

            // Activate the loaded document and prompt for rebuild if the model changed
            swModel = (ModelDoc2)swApp.ActivateDoc3("loaded_document", false, (int)swRebuildOnActivation_e.swUserDecision, ref Errors);
            Debug.Print("Error code after document activation: " + Errors.ToString());

        }

        public SldWorks swApp;

    }
}