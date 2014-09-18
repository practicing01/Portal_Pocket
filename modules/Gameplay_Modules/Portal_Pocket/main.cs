function Module_Portal_Pocket::create(%this)
{

exec("./assets/scripts/scripts.cs");

%this.Load();

}

function Module_Portal_Pocket::destroy(%this)
{

%this.Unload();

}
