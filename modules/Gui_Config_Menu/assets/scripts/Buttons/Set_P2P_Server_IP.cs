function Module_Gui_Config_Menu::Set_P2P_Server_IP(%this,%GuiButtonCtrl)
{

$pref::Portal_Pocket::P2P_IP=%this.GuiControl_Config_Menu->GuiTextEditCtrl_P2P_IP.getText();

Portal_Pocket.Preferences_Save();

}
