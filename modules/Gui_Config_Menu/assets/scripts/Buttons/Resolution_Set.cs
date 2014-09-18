function Class_GuiPopUpMenuCtrl_Resolution_List::onSelect(%this,%GuiButtonCtrl)
{

%String_Resolution=%this.getText();

if(setRes(%String_Resolution.X,%String_Resolution.Y,%String_Resolution.Z))
{

$pref::Video::defaultResolution = %String_Resolution.X SPC %String_Resolution.Y;

$pref::Video::windowedRes = %String_Resolution;

Portal_Pocket.Preferences_Save();

Portal_Pocket.Resolution=%String_Resolution.X SPC %String_Resolution.Y;

%Y_Times_100=100*Portal_Pocket.Resolution.Y;
%Cam_Y=%Y_Times_100/Portal_Pocket.Resolution.X;

SceneWindow_Portal_Pocket.setCameraSize(100,%Cam_Y);

Gui_Portal_Pocket_Overlay.resize(0,0,Portal_Pocket.Resolution.X,Portal_Pocket.Resolution.Y);

}

}
