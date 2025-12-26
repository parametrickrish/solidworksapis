//----------------------------------------------------------------------
// Preconditions:
// 1. Copy public_documents\samples utorial\EDraw\claw to c: est\claw.
// 2. Open c: est\claw\claw-mechanism.sldasm and save the file as 
//    claw-mechanism-copy.sldasm.
// 3. Close claw-mechanism-copy.sldasm and reopen claw-mechanism.sldasm.
// 4. Open the Immediate window.
//
// Postconditions:
// 1. Renames the center component to centerXXX.
// 2. Fires the RenameItemNotify event.
// 3. Saves the assembly.
// 4. Fires the RenamedDocumentNotify event.
// 5. Updates references.
// 6. Examine the FeatureManager design tree and Immediate window.
// 7. Close claw-mechanism.sldasm and open
//    c: est\claw\claw-mechanism-copy.sldasm to verify that the
//    center component was renamed to centerXXX.
//---------------------------------------------------------------------

using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Runtime.InteropServices;
using System;
using System.Diagnostics;
using System.Collections;

namespace Macro1CSharp.csproj
{
    public partial class SolidWorksMacro
    {
        public AssemblyDoc assy;

        public void Main()
        {
            ModelDoc2 swModel = default(ModelDoc2);
            ModelDocExtension swModelDocExt = default(ModelDocExtension);
            AssemblyDoc swAssy = default(AssemblyDoc);
            Hashtable openAssembly = default(Hashtable);
            int errors = 0;
            int warnings = 0;
            bool status = false;

            swAssy = (AssemblyDoc)swApp.ActiveDoc;

            //Set up event
            assy = (AssemblyDoc)swAssy;
            openAssembly = new Hashtable();
            AttachEventHandlers();

            swModel = (ModelDoc2)swAssy;
            swModelDocExt = (ModelDocExtension)swModel.Extension;
            status = swModelDocExt.SelectByID2("center-1@claw-mechanism", "COMPONENT", 0, 0, 0, false, 0, null, 0);
            errors = swModelDocExt.RenameDocument("centerXXX");
            swModelDocExt.Rebuild((int)swRebuildOptions_e.swRebuildAll);
            status = swModel.Save3((int)swSaveAsOptions_e.swSaveAsOptions_Silent + (int)swSaveAsOptions_e.swSaveAsOptions_SaveReferenced, ref errors, ref warnings);

        }

        public void AttachEventHandlers()
        {
            AttachSWEvents();
        }

        public void AttachSWEvents()
        {
            if ((assy != null))
            {
                assy.RenameItemNotify += this.assy_RenameItemNotify;
                assy.RenamedDocumentNotify += this.assy_RenamedDocumentNotify;
            }

        }

        //Fire notification when item is renamed
        public int assy_RenameItemNotify(int entType, string oldName, string newName)
        {
            Debug.Print("RenameItemNotify fired");
            return 0;
        }


        //Fire notification for Rename Documents dialog
        public int assy_RenamedDocumentNotify(ref object swObj)
        {
            RenamedDocumentReferences swRenamedDocumentReferences = default(RenamedDocumentReferences);
            object[] searchPaths = null;
            object[] pathNames = null;
            int i = 0;
            int nbr = 0;

            swRenamedDocumentReferences = (RenamedDocumentReferences)swObj;

            swRenamedDocumentReferences.UpdateWhereUsedReferences = true;
            swRenamedDocumentReferences.IncludeFileLocations = true;

            searchPaths = (object[])swRenamedDocumentReferences.GetSearchPath();
            nbr = searchPaths.Length - 1;
            Debug.Print("Search paths:");
            for (i = 0; i <= nbr; i++)
            {
                Debug.Print(" " + searchPaths[i]);
            }

            swRenamedDocumentReferences.Search();

            pathNames = (object[])swRenamedDocumentReferences.ReferencesArray();
            nbr = pathNames.Length - 1;
            Debug.Print("References:");
            for (i = 0; i <= nbr; i++)
            {
                Debug.Print(" " + pathNames[i]);
            }

            swRenamedDocumentReferences.CompletionAction = (int)swRenamedDocumentFinalAction_e.swRenamedDocumentFinalAction_Ok;

            Debug.Print("RenamedDocumentNotify fired");

            return 0;

        }
        /// <summary>
        ///  The SldWorks swApp variable is pre-assigned for you.
        /// </summary>
        public SldWorks swApp;
    }
}