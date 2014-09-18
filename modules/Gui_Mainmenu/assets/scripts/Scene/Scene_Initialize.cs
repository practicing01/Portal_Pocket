function Module_Gui_Main_Menu::Scene_Initialize(%this)
{

%Sprite_BG_Render=new Sprite()
{

Position="0 0";
Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_BG_Render);
Image="Module_Gui_Main_Menu:Image_BG_Render";

BodyType="static";

};

Scene_Portal_Pocket.add(%Sprite_BG_Render);

if (isObject(Portal_Pocket.GameConnection_Client_Connection))
{

Portal_Pocket.GameConnection_Client_Connection.delete("Returning to Main Menu.");

}

if (isObject(Module_Lobby))
{

Module_Lobby.Scene_Unload();

}

//ModuleDatabase.LoadExplicit("Module_Lobby");

}
