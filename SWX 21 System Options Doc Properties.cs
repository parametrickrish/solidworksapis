using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SldWorks;
using SwConst;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SldWorks.SldWorks swApp = new SldWorks.SldWorks();
            SldWorks.ModelDoc2 swModel = null;
            
            bool boolstatus = false;

            TextFormat swTextFormat = default(TextFormat);

            object TextFormatObj = null;

            ModelDocExtension ModelDocExtension = default(ModelDocExtension);

            swModel = (ModelDoc2)swApp.ActiveDoc;

            if (swModel == null)
            {
                swApp.SendMsgToUser2("Please open a part/drw/asm", 2, 2);
                return;
            }

            ModelDocExtension = swModel.Extension;

            //The following call demonstrates how to get and set a Tools > Options > System Options > General option


            //Custom property used as component description

            boolstatus = swApp.SetUserPreferenceStringValue((int)swUserPreferenceStringValue_e.swCustomPropertyUsedAsComponentDescription, "Status");

            Debug.Print("Tools > Options > System Options > General > Custom property used as component description: " + swApp.GetUserPreferenceStringValue((int)swUserPreferenceStringValue_e.swCustomPropertyUsedAsComponentDescription));



            //The following calls demonstrate how to get and set Tools > Options > System Options > View options



            //Reverse mouse wheel zoom direction

            swApp.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swViewReverseWheelZoomDirection, true);

            Debug.Print("Tools > Options > System Options > View > Reverse mouse wheel zoom direction: " + swApp.GetUserPreferenceToggle((int)swUserPreferenceToggle_e.swViewReverseWheelZoomDirection));

            //View rotation - Arrow keys

            boolstatus = swApp.SetUserPreferenceDoubleValue((int)swUserPreferenceDoubleValue_e.swViewRotationArrowKeys, 0.2268928027593);


            //1 radian = 180º/p = 57.295779513º or approximately 57.3º

            Debug.Print("Tools > Options > System Options > View > Arrow keys: " + swApp.GetUserPreferenceDoubleValue((int)swUserPreferenceDoubleValue_e.swViewRotationArrowKeys) * 57.3);

            //Convert to degrees

            //View rotation - Mouse speed

            boolstatus = swApp.SetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swViewRotationMouseSpeed, 56);

            Debug.Print("Tools > Options > System Options > View > Mouse speed: " + swApp.GetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swViewRotationMouseSpeed));

            //Transitions - View transition

            boolstatus = swApp.SetUserPreferenceDoubleValue((int)swUserPreferenceDoubleValue_e.swViewAnimationSpeed, 2.5);

            Debug.Print("Tools > Options > System Options > View > View transition: " + swApp.GetUserPreferenceDoubleValue((int)swUserPreferenceDoubleValue_e.swViewAnimationSpeed));

            //Transitions - Hide/show component

            boolstatus = swApp.SetUserPreferenceDoubleValue((int)swUserPreferenceDoubleValue_e.swViewTransitionHideShowComponent, 0.8000000119209);

            Debug.Print("Tools > Options > System Options > View > Hide/show component: " + swApp.GetUserPreferenceDoubleValue((int)swUserPreferenceDoubleValue_e.swViewTransitionHideShowComponent));

            //Transitions - Isolate

            boolstatus = swApp.SetUserPreferenceDoubleValue((int)swUserPreferenceDoubleValue_e.swViewTransitionIsolate, 1.222222208977);

            Debug.Print("Tools > Options > System Options > View > Isolate: " + swApp.GetUserPreferenceDoubleValue((int)swUserPreferenceDoubleValue_e.swViewTransitionIsolate));



            //The following calls demonstrate how to get and set the Tools > Options > Document Properties > Drafting Standard option

            //Maps the value returned by the GetUserPreferenceInteger method to the corresponding enumerator member in the enumerator online help



            //Overall drafting standard

            boolstatus = ModelDocExtension.SetUserPreferenceInteger((int)swUserPreferenceIntegerValue_e.swDetailingDimensionStandard, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, (int)swDetailingStandard_e.swDetailingStandardISO);

            string sText = null;

            sText = "Tools > Options > Document Properties > Drafting Standard > Overall drafting standard is ";

            switch (ModelDocExtension.GetUserPreferenceInteger((int)swUserPreferenceIntegerValue_e.swDetailingDimensionStandard, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified))

            {

                case 1:

                    Debug.Print(sText + "ANSI");

                    break;

                case 2:

                    Debug.Print(sText + "ISO");

                    break;

                case 3:

                    Debug.Print(sText + "DIN");

                    break;

                case 4:

                    Debug.Print(sText + "JIS");

                    break;

                case 5:

                    Debug.Print(sText + "BS");

                    break;

                case 6:

                    Debug.Print(sText + "GOST");

                    break;

                case 7:

                    Debug.Print(sText + "GB");

                    break;

                case 8:

                    Debug.Print(sText + "User Defined");

                    break;

            }

            //The following calls demonstrate how to get and set Tools > Options > Document Properties > Annotations > Balloons options

            //Maps the value returned by the GetUserPreferenceInteger method to the corresponding enumerator member in the enumerator online help



            //Leader style - Leader Thickness

            boolstatus = ModelDocExtension.SetUserPreferenceInteger((int)swUserPreferenceIntegerValue_e.swDetailingBalloonLeaderLineThickness, 0, (int)swLineWeights_e.swLW_NUMBER);

            Debug.Print("Tools > Options > Document Properties > Annotations > Balloons > Leader Thickness: " + ModelDocExtension.GetUserPreferenceInteger((int)swUserPreferenceIntegerValue_e.swDetailingBalloonLeaderLineThickness, 0));

            //Leader style - Custom leader thickness

            boolstatus = ModelDocExtension.SetUserPreferenceDouble((int)swUserPreferenceDoubleValue_e.swDetailingBalloonLeaderLineThicknessCustom, 0, 0.00028);

            Debug.Print("Tools > Options > Document Properties > Annotations > Balloons > Custom Leader Thickness: " + ModelDocExtension.GetUserPreferenceDouble((int)swUserPreferenceDoubleValue_e.swDetailingBalloonLeaderLineThicknessCustom, 0));

            //Frame style - Frame Thickness

            boolstatus = ModelDocExtension.SetUserPreferenceInteger((int)swUserPreferenceIntegerValue_e.swDetailingBalloonFrameLineThickness, 0, (int)swLineWeights_e.swLW_NUMBER);

            Debug.Print("Tools > Options > Document Properties > Annotations > Balloons > Frame Thickness: " + ModelDocExtension.GetUserPreferenceInteger((int)swUserPreferenceIntegerValue_e.swDetailingBalloonFrameLineThickness, 0));

            //Frame style - Custom frame thickness

            boolstatus = ModelDocExtension.SetUserPreferenceDouble((int)swUserPreferenceDoubleValue_e.swDetailingBalloonFrameLineThicknessCustom, 0, 0.00028);

            Debug.Print("Tools > Options > Document Properties > Annotations > Balloons > Custom Frame Thickness: " + ModelDocExtension.GetUserPreferenceDouble((int)swUserPreferenceDoubleValue_e.swDetailingBalloonFrameLineThicknessCustom, 0));

            //Text - Upper - Custom property

            boolstatus = ModelDocExtension.SetUserPreferenceString((int)swUserPreferenceStringValue_e.swDetailingBOMUpperCustomProperty, 0, "Source");

            Debug.Print("Tools > Options > Document Properties > Annotations > Balloons > Text Upper Custom property: " + ModelDocExtension.GetUserPreferenceString((int)swUserPreferenceStringValue_e.swDetailingBOMUpperCustomProperty, 0));

            //Single balloon - Style

            boolstatus = ModelDocExtension.SetUserPreferenceInteger((int)swUserPreferenceIntegerValue_e.swDetailingBOMBalloonStyle, 0, (int)swBalloonStyle_e.swBS_Triangle);

            Debug.Print("Tools > Options > Document Properties > Annotations > Balloons > Single balloon - Style: " + ModelDocExtension.GetUserPreferenceInteger((int)swUserPreferenceIntegerValue_e.swDetailingBOMBalloonStyle, 0));

            //Single balloon - Size

            boolstatus = ModelDocExtension.SetUserPreferenceInteger((int)swUserPreferenceIntegerValue_e.swDetailingBOMBalloonFit, 0, (int)swBalloonFit_e.swBF_3Chars);

            Debug.Print("Tools > Options > Document Properties > Annotations > Balloons > Single balloon - Size: " + ModelDocExtension.GetUserPreferenceInteger((int)swUserPreferenceIntegerValue_e.swDetailingBOMBalloonFit, 0));

            //Stacked balloons - Style

            boolstatus = ModelDocExtension.SetUserPreferenceInteger((int)swUserPreferenceIntegerValue_e.swDetailingBOMStackedBalloonStyle, 0, (int)swBalloonStyle_e.swBS_Triangle);

            Debug.Print("Tools > Options > Document Properties > Annotations > Balloons > Stacked balloons - Style: " + ModelDocExtension.GetUserPreferenceInteger((int)swUserPreferenceIntegerValue_e.swDetailingBOMStackedBalloonStyle, 0));

            //Stacked balloons - Size

            boolstatus = ModelDocExtension.SetUserPreferenceInteger((int)swUserPreferenceIntegerValue_e.swDetailingBOMStackedBalloonFit, 0, (int)swBalloonFit_e.swBF_3Chars);

            Debug.Print("Tools > Options > Document Properties > Annotations > Balloons > Stacked balloons - Size: " + ModelDocExtension.GetUserPreferenceInteger((int)swUserPreferenceIntegerValue_e.swDetailingBOMStackedBalloonFit, 0));

            //Auto balloon layout

            boolstatus = ModelDocExtension.SetUserPreferenceInteger((int)swUserPreferenceIntegerValue_e.swDetailingAutoBalloonLayout, 0, (int)swBalloonLayoutType_e.swDetailingBalloonLayout_Right);

            Debug.Print("Tools > Options > Document Properties > Annotations > Balloons > Auto balloon layout: " + ModelDocExtension.GetUserPreferenceInteger((int)swUserPreferenceIntegerValue_e.swDetailingAutoBalloonLayout, 0));

            //Leader display - Use document leader length

            boolstatus = ModelDocExtension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swDetailingBalloonUseDocBentLeaderLength, 0, true);

            Debug.Print("Tools > Options > Document Properties > Annotations > Balloons > Leader display - Use document leader length: " + ModelDocExtension.GetUserPreferenceToggle((int)swUserPreferenceToggle_e.swDetailingBalloonUseDocBentLeaderLength, 0));

            //Layer

            boolstatus = ModelDocExtension.SetUserPreferenceString((int)swUserPreferenceStringValue_e.swDetailingLayer, (int)swUserPreferenceOption_e.swDetailingBalloon, "test");

            Debug.Print("Tools > Options > Document Properties > Annotations > Balloons > Layer: " + ModelDocExtension.GetUserPreferenceString((int)swUserPreferenceStringValue_e.swDetailingLayer, (int)swUserPreferenceOption_e.swDetailingBalloon));

            //Font

            TextFormatObj = ModelDocExtension.GetUserPreferenceTextFormat((int)swUserPreferenceTextFormat_e.swDetailingBalloonTextFormat, 0);

            swTextFormat = (TextFormat)TextFormatObj;

            swTextFormat.Italic = true;

            swTextFormat.Bold = true;

            boolstatus = ModelDocExtension.SetUserPreferenceTextFormat((int)swUserPreferenceTextFormat_e.swDetailingBalloonTextFormat, 0, swTextFormat);

            Debug.Print("Tools > Options > Document Properties > Annotations > Balloons > Font is italic and bold: " + boolstatus);

        }

    }
}
    

