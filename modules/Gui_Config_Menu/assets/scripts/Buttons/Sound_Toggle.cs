function Module_Gui_Config_Menu::Sound_Toggle(%this,%GuiButtonCtrl)
{

if ($pref::Audio::sfxVolume==1.0)
{

$pref::Audio::sfxVolume = 0;

$pref::Audio::musicVolume = 0;

}
else
{

$pref::Audio::sfxVolume = 1.0;

$pref::Audio::musicVolume = 1.0;

}

Portal_Pocket.Preferences_Save();

}
