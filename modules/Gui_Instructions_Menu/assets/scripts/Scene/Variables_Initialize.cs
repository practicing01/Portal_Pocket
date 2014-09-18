function Module_Gui_Instructions_Menu::Variables_Initialize(%this)
{

%this.Gui_Text_ML=0;

%this.GuiControl_Instructions_Menu=TamlRead("./../../gui/GuiControl_Instructions_Menu.gui.taml");

%this.GuiControl_Instructions_Menu.resize(0,0,Gui_Portal_Pocket_Overlay.Extent.X,Gui_Portal_Pocket_Overlay.Extent.Y);

Set_Gui_Module_ID_Parent(%this.GuiControl_Instructions_Menu,%this);

Portal_Pocket.add(%this.GuiControl_Instructions_Menu);

Gui_Portal_Pocket_Overlay.add(%this.GuiControl_Instructions_Menu);

}
 