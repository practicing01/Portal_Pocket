function Portal_Pocket::create(%this)
{

/*Core Misc*/

exec("./scripts/Misc/Misc_Initialize.cs");

initializeCanvas("Portal_Pocket");

Canvas.BackgroundColor="black";

Canvas.UseBackgroundColor=true;

initializeOpenAL();

/*Gui Init*/
exec("./gui/guiProfiles.cs");

/*Global Variables*/

exec("./scripts/Variables_Initialize.cs");

%this.Variables_Initialize();

/*Global Functions*/
exec("./scripts/Functions_Initialize/Functions_Initialize.cs");

/*Core Scene*/
exec("./scenes/Scene_Portal_Pocket.cs");

/*Network*/
exec("./scripts/Network/Network.cs");

Window_Create_Portal_Pocket();

Scene_Create_Portal_Pocket();

Portal_Pocket.add(TamlRead("./gui/ConsoleDialog.gui.taml"));

GlobalActionMap.bind(keyboard,"tilde",toggleConsole);

new RenderProxy(CannotRenderProxy)
{

Image="Portal_Pocket:CannotRender";

};

Portal_Pocket.add(CannotRenderProxy);

Portal_Pocket.Camera_Size=SceneWindow_Portal_Pocket.getCameraSize();

%Local_Time=getLocalTime();

%Local_Time=stripChars(%Local_Time,":/");

%Local_Time=getWord(%Local_Time,0)+getWord(%Local_Time,1);

setRandomSeed(%Local_Time);

/*Load Play*/
exec("./scripts/Play_Load/Play_Load.cs");

%this.Play_Load();

}

function Portal_Pocket::destroy(%this)
{
Window_Destroy_Portal_Pocket();
}
