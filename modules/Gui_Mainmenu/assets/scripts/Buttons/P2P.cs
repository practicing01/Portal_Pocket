function Module_Gui_Main_Menu::P2P(%this,%GuiButtonCtrl)
{

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

setNetPort(9003);//OVER NINE THOUSAND

Portal_Pocket.GameConnection_Client_Connection=new GameConnection();

Portal_Pocket.GameConnection_Client_Connection.setConnectArgs
(

$pref::Portal_Pocket::Player_Name,//Connector Name

"Client"//Connector Type

);

echo("Connecting to P2P server:" SPC $pref::Portal_Pocket::P2P_IP);

Portal_Pocket.GameConnection_Client_Connection.connect($pref::Portal_Pocket::P2P_IP);

}
