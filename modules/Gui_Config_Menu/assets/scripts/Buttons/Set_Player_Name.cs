function Module_Gui_Config_Menu::Set_Player_Name(%this,%GuiButtonCtrl)
{

$pref::Portal_Pocket::Player_Name=%this.GuiControl_Config_Menu->GuiTextEditCtrl_Player_Name.getText();

Portal_Pocket.Preferences_Save();

}
