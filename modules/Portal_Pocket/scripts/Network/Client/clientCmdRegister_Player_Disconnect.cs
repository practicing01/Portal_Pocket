function clientCmdRegister_Player_Disconnect(%GameConnection_Client_Sender)
{

echo("Register_Player_Disconnect:" SPC %GameConnection_Client_Sender);

for (%x=0;%x<Portal_Pocket.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client=Portal_Pocket.Simset_Client_List.getObject(%x);

if (%ScriptObject_Client.GameConnection_Handle==%GameConnection_Client_Sender)
{

for (%y=0;%y<Portal_Pocket.SimSet_Modules_That_Synchronize_Clients.getCount();%y++)
{

%Module_ID=Portal_Pocket.SimSet_Modules_That_Synchronize_Clients.getObject(%y);

%Module_ID.Synchronize_Clients(%ScriptObject_Client,false);

}

Portal_Pocket.Simset_Client_List.remove(%ScriptObject_Client);

%ScriptObject_Client.delete();

return;

}

}

}
