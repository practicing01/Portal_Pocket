function Portal_Pocket::Play_Load(%this)
{

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Portal_Pocket_Input_Controller";

};

SceneWindow_Portal_Pocket.addInputListener(%this.Script_Object_Input_Controller);

/*Load splashes*/

ModuleDatabase.LoadExplicit("Splashes");

Splashes.Scene_Load();

}
