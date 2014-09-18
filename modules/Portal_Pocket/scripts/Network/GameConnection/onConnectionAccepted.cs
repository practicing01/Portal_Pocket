//client
function GameConnection::onConnectionAccepted(%this)
{

echo("GameConnection onConnectionAccepted. Handle:" SPC %this);

if (isObject(Portal_Pocket.GameConnection_Master_Server_Query)&&!Portal_Pocket.Bool_Local_Connection)//This is a query connection.
{

echo("Querying master server.");

if (isObject(Portal_Pocket.Simset_Server_List))
{

Portal_Pocket.Simset_Server_List.deleteObjects();

Module_Gui_Main_Menu.GuiControl_Main_Menu->GuiScrollCtrl_Main_Menu_Server_List->GuiListBoxCtrl_Main_Menu_Server_List.clearItems();

}

commandToServer('Master_Server_Query_Request');

}
else if (isObject(Portal_Pocket.GameConnection_Client_Connection)&&Portal_Pocket.Bool_Is_Client)//This is a client to server connection.
{

Module_Gui_Main_Menu.Scene_Unload();

Module_Lobby.Scene_Load();

}

}
