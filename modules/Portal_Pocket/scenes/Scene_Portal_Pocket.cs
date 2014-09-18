function Window_Create_Portal_Pocket()
{

if (!isObject(SceneWindow_Portal_Pocket))
{

new SceneWindow(SceneWindow_Portal_Pocket);   

SceneWindow_Portal_Pocket.Profile=Gui_Profile_SceneWindow_Portal_Pocket;

Canvas.setContent(SceneWindow_Portal_Pocket);                     

}

SceneWindow_Portal_Pocket.stopCameraMove();
SceneWindow_Portal_Pocket.dismount();
SceneWindow_Portal_Pocket.setViewLimitOff();
SceneWindow_Portal_Pocket.setRenderGroups(Portal_Pocket.All_Bits);
SceneWindow_Portal_Pocket.setRenderLayers(Portal_Pocket.All_Bits);
SceneWindow_Portal_Pocket.setObjectInputEventGroupFilter(Portal_Pocket.All_Bits);
SceneWindow_Portal_Pocket.setObjectInputEventLayerFilter(Portal_Pocket.All_Bits);
SceneWindow_Portal_Pocket.setUseObjectInputEvents(true);
SceneWindow_Portal_Pocket.setLockMouse(true);
SceneWindow_Portal_Pocket.setCameraPosition(0,0);
SceneWindow_Portal_Pocket.setCameraZoom(1);
SceneWindow_Portal_Pocket.setCameraAngle(0);

Portal_Pocket.Resolution=getRes();
%Y_Times_100=100*Portal_Pocket.Resolution.Y;
%Cam_Y=%Y_Times_100/Portal_Pocket.Resolution.X;

SceneWindow_Portal_Pocket.setCameraSize(100,%Cam_Y);

if (!isObject(Gui_Portal_Pocket_Overlay))
{

new GuiControl(Gui_Portal_Pocket_Overlay)
{

Position="0 0";

Extent=Portal_Pocket.Resolution;

Profile=gui_profile_modalless;

class="Class_Gui_Portal_Pocket_Overlay";

};   

SceneWindow_Portal_Pocket.addGuiControl(Gui_Portal_Pocket_Overlay);

Gui_Portal_Pocket_Overlay.setActive(true);

}

}

//-----------------------------------------------------------------------------

function Window_Destroy_Portal_Pocket()
{
    
if (isObject(SceneWindow_Portal_Pocket))
{

SceneWindow_Portal_Pocket.delete();

}

}

//-----------------------------------------------------------------------------

function Scene_Destroy_Portal_Pocket()
{

if (isObject(Scene_Portal_Pocket))
{

Scene_Portal_Pocket.delete();

}

}

function Scene_Set_To_Window()
{

if (!isObject(Scene_Portal_Pocket))
{

error("Cannot set Portal_Pocket Scene to Window as the Scene is invalid.");
return;

}
    
SceneWindow_Portal_Pocket.setScene(Scene_Portal_Pocket);

SceneWindow_Portal_Pocket.stopCameraMove();
SceneWindow_Portal_Pocket.dismount();
SceneWindow_Portal_Pocket.setViewLimitOff();
SceneWindow_Portal_Pocket.setRenderGroups(Portal_Pocket.All_Bits);
SceneWindow_Portal_Pocket.setRenderLayers(Portal_Pocket.All_Bits);
SceneWindow_Portal_Pocket.setObjectInputEventGroupFilter(Portal_Pocket.All_Bits);
SceneWindow_Portal_Pocket.setObjectInputEventLayerFilter(Portal_Pocket.All_Bits);
SceneWindow_Portal_Pocket.setUseObjectInputEvents(true);
SceneWindow_Portal_Pocket.setLockMouse(true);
SceneWindow_Portal_Pocket.setCameraPosition(0,0);
SceneWindow_Portal_Pocket.setCameraZoom(1);
SceneWindow_Portal_Pocket.setCameraAngle(0);

Portal_Pocket.Resolution=getRes();
%Y_Times_100=100*Portal_Pocket.Resolution.Y;
%Cam_Y=%Y_Times_100/Portal_Pocket.Resolution.X;

SceneWindow_Portal_Pocket.setCameraSize(100,%Cam_Y);

}

function Scene_Create_Portal_Pocket()
{

//Scene_Destroy_Portal_Pocket();

//new Scene(Scene_Portal_Pocket);

if (!isObject(SceneWindow_Portal_Pocket))
{

error("Portal_Pocket: did not create scene; no window available.");

//error("Portal_Pocket: Created scene but no window available.");

return;

}

Scene_Destroy_Portal_Pocket();

new Scene(Scene_Portal_Pocket);

Scene_Set_To_Window();    
}

function Scene_Set_Custom(%Scene)
{

if (!isObject(%Scene))
{

error("Cannot set Portal_Pocket to use an invalid Scene.");
return;

}
   
Scene_Destroy_Portal_Pocket();

%Scene.setName("Scene_Portal_Pocket");

//%Scene.class="Class_Scene_Portal_Pocket";

Scene_Set_To_Window();

//%Scene.setDebugOn("joints");
//%Scene.setDebugOn("metrics");
//%Scene.setDebugOn("fps");
//%Scene.setDebugOn("wireframe");
//%Scene.setDebugOn("aabb");
//%Scene.setDebugOn("oobb");
//%Scene.setDebugOn("sleep");
//%Scene.setDebugOn("collision");
//%Scene.setDebugOn("position");
//%Scene.setDebugOn("sort");
//%Scene.setDebugOn("controllers");

}

//-----------------------------------------------------------------------------

/*function Class_Scene_Portal_Pocket::onSceneCollision(%this,%Scene_Object_0,%Scene_Object_1,%Collision_Details)
{

echo(%Scene_Object_0.class);

echo(%Scene_Object_1.class);

}*/

function Class_Gui_Portal_Pocket_Overlay::onControlDropped(%this,%GuiControl_Target,%Vector_2D_Position)
{

%GuiControl_Target.onControlDropped(%Vector_2D_Position);

}
