function Class_GuiListBoxCtrl_Main_Menu_Server_List::onDoubleClick(%this)
{

%Server_Name=%this.getItemText(%this.getSelectedItem());

%ScriptObject_Server=0;

for (%x=0;%x<Portal_Pocket.Simset_Server_List.getCount();%x++)
{

%ScriptObject=Portal_Pocket.Simset_Server_List.getObject(%x);

if (%ScriptObject.Connector_Name$=%Server_Name)
{

%ScriptObject_Server=%ScriptObject;

break;

}

}

if (%ScriptObject_Server==0){return;}

if (isObject(Portal_Pocket.GameConnection_Master_Server_Query))
{

Portal_Pocket.GameConnection_Master_Server_Query.delete("Stopping query, connecting to server.");

}

if (isObject(Portal_Pocket.GameConnection_Client_Connection))
{

Portal_Pocket.GameConnection_Client_Connection.delete("Connecting to a different server.");

}

Portal_Pocket.GameConnection_Client_Connection=new GameConnection();

Portal_Pocket.GameConnection_Client_Connection.setConnectArgs
(

$pref::Portal_Pocket::Player_Name,//Connector Name

"Client"//Connector Type

);

echo("Connecting to server:" SPC %ScriptObject_Server.Connector_Name SPC "at:" SPC %ScriptObject_Server.IP_Address);

Portal_Pocket.GameConnection_Client_Connection.connect(%ScriptObject_Server.IP_Address);

}
