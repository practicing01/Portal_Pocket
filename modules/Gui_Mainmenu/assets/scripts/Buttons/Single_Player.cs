function Module_Gui_Main_Menu::Single_Player(%this,%GuiButtonCtrl)
{

//Load gameplay module here

Module_Gui_Main_Menu.Scene_Unload();

ModuleDatabase.LoadExplicit("Module_Portal_Pocket");

return;

if (Portal_Pocket.Bool_Hosting_Server||Portal_Pocket.Bool_Hosting_Master_Server)
{

return;

}

if (isObject(Portal_Pocket.GameConnection_Master_Server_Query))
{

Portal_Pocket.GameConnection_Master_Server_Query.delete("Stopping query, connecting to server.");

}

if (isObject(Portal_Pocket.GameConnection_Client_Connection))
{

Portal_Pocket.GameConnection_Client_Connection.delete("Connecting to a different server.");

}

setNetPort(9002);//OVER NINE THOUSAND

ClientGroup.deleteObjects();//Clear clients.

Portal_Pocket.Bool_Local_Connection=true;

Portal_Pocket.Bool_Hosting_Server=true;

Module_Server.Server_Load();

Portal_Pocket.GameConnection_Client_Connection=new GameConnection();

Portal_Pocket.GameConnection_Client_Connection.setConnectArgs
(

$pref::Portal_Pocket::Player_Name,//Connector Name

"Client"//Connector Type

);

Portal_Pocket.GameConnection_Client_Connection.connectLocal();

}
