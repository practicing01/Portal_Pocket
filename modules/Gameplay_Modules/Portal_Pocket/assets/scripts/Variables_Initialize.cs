function Module_Portal_Pocket::Variables_Initialize(%this)
{

%this.Sprite_White_Ball=0;

%this.Int_Strike_Force=100;

%this.Int_Pocketed_Count=0;

/***********************************************************************************/

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Input_Controller";

Module_ID_Parent=%this;

};

SceneWindow_Portal_Pocket.addInputListener(%this.Script_Object_Input_Controller);

/***********************************************************************************/

//Return to Main Menu button.
/*
%this.GuiButtonCtrl_MainMenu=new GuiButtonCtrl()
{

class="Class_GuiButtonCtrl_Module_Portal_Pocket";

String_Action="Main_Menu";

Profile="Black_0ButtonProfile";

Text="X";

ButtonType="PushButton";

HorizSizing="relative";

VertSizing="relative";

Position="760 0";

Extent="40 40";

Module_ID_Parent=%this;

};

Gui_Portal_Pocket_Overlay.add(%this.GuiButtonCtrl_MainMenu);
*/

}
