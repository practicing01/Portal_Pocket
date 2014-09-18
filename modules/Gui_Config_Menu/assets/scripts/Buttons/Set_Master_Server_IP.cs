function Module_Gui_Config_Menu::Set_Master_Server_IP(%this,%GuiButtonCtrl)
{

$pref::Portal_Pocket::Master_IP=%this.GuiControl_Config_Menu->GuiTextEditCtrl_IP.getText();

Portal_Pocket.Preferences_Save();

}
