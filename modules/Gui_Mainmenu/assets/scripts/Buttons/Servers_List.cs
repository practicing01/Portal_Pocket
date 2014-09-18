function Module_Gui_Main_Menu::Servers_List(%this,%GuiButtonCtrl)
{

//queryLanServers(0,0,"","",0,0,0,0,0,0,0);return;

//querySingleServer("192.168.1.100:9001","");return;

if (Portal_Pocket.Bool_Hosting_Server||Portal_Pocket.Bool_Hosting_Master_Server)
{

return;

}

if (!isObject(Portal_Pocket.GameConnection_Master_Server_Query))
{

setNetPort(9003);//OVER NINE THOUSAND

Portal_Pocket.GameConnection_Master_Server_Query=new GameConnection();

Portal_Pocket.GameConnection_Master_Server_Query.setConnectArgs
(

$pref::Portal_Pocket::Player_Name,//Connector Name

"Client"//Connector Type

);

if (Portal_Pocket.Bool_Local_Connection)
{

echo("Can't query master server, this is a local connection.");

}
else
{

echo("Connecting to the master server for query.");

Portal_Pocket.GameConnection_Master_Server_Query.connect($pref::Portal_Pocket::Master_IP);

}

}

}
