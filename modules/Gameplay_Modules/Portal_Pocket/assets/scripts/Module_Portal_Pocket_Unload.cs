function Module_Portal_Pocket::Unload(%this)
{

%this.Ass_Unload();

if (isObject(%this.Script_Object_Input_Controller)&&isObject(SceneWindow_Portal_Pocket))
{

SceneWindow_Portal_Pocket.removeInputListener(%this.Script_Object_Input_Controller);

%this.Script_Object_Input_Controller.delete();

}

}
