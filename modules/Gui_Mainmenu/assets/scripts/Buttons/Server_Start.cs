function Module_Gui_Main_Menu::Server_Start(%this,%GuiButtonCtrl)
{

Portal_Pocket.Bool_Hosting_Server=!Portal_Pocket.Bool_Hosting_Server;

if (Portal_Pocket.Bool_Hosting_Server)
{

%GuiButtonCtrl.setText("Stop Server");

setNetPort(9002);//OVER NINE THOUSAND

Module_Server.Server_Load();

}
else
{

%GuiButtonCtrl.setText("Start Server");

Module_Server.Server_Unload();

}

}
