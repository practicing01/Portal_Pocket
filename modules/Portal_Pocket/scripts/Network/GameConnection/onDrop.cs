function GameConnection::onDrop(%this,%Reason)
{

echo(%this SPC "GameConnection onDrop. Reason:" SPC %Reason);

if (Portal_Pocket.Bool_Hosting_Server||Portal_Pocket.Bool_Local_Connection)
{

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%GameConnection_Client=ClientGroup.getObject(%x);

if (%GameConnection_Client.Connector_Type$="Client"&&%GameConnection_Client!=%this)
{

commandToClient(%GameConnection_Client,'Register_Player_Disconnect',%this);

}

}

}

}
