function Portal_Pocket::Preferences_Save(%this)
{

%FileObject_File_Out=new FileObject();

%FileObject_File_Out.openForWrite("./../../../../preferences.cs");

%FileObject_File_Out.writeLine("$pref::Portal_Pocket::aabbOption =" SPC $pref::Portal_Pocket::aabbOption @ ";");

%FileObject_File_Out.writeLine("$pref::Portal_Pocket::cameraMouseZoomRate =" SPC $pref::Portal_Pocket::cameraMouseZoomRate @ ";");

%FileObject_File_Out.writeLine("$pref::Portal_Pocket::cameraTouchZoomRate =" SPC $pref::Portal_Pocket::cameraTouchZoomRate @ ";");

%FileObject_File_Out.writeLine("$pref::Portal_Pocket::collisionOption =" SPC $pref::Portal_Pocket::collisionOption @ ";");

%FileObject_File_Out.writeLine("$pref::Portal_Pocket::defaultBackgroundColor = \"" @ $pref::Portal_Pocket::defaultBackgroundColor @ "\";");

%FileObject_File_Out.writeLine("$pref::Portal_Pocket::fpsmetricsOption =" SPC $pref::Portal_Pocket::fpsmetricsOption @ ";");

%FileObject_File_Out.writeLine("$pref::Portal_Pocket::jointsOption =" SPC $pref::Portal_Pocket::jointsOption @ ";");

%FileObject_File_Out.writeLine("$pref::Portal_Pocket::metricsOption =" SPC $pref::Portal_Pocket::metricsOption @ ";");

%FileObject_File_Out.writeLine("$pref::Portal_Pocket::oobbOption =" SPC $pref::Portal_Pocket::oobbOption @ ";");

%FileObject_File_Out.writeLine("$pref::Portal_Pocket::positionOption =" SPC $pref::Portal_Pocket::positionOption @ ";");

%FileObject_File_Out.writeLine("$pref::Portal_Pocket::sleepOption =" SPC $pref::Portal_Pocket::sleepOption @ ";");

%FileObject_File_Out.writeLine("$pref::Portal_Pocket::sortOption =" SPC $pref::Portal_Pocket::sortOption @ ";");

%FileObject_File_Out.writeLine("$pref::Portal_Pocket::wireframeOption =" SPC $pref::Portal_Pocket::wireframeOption @ ";");

%FileObject_File_Out.writeLine("$pref::Portal_Pocket::Player_Name = \"" @ $pref::Portal_Pocket::Player_Name @ "\";");

%FileObject_File_Out.writeLine("$pref::Portal_Pocket::Master_IP = \"" @ $pref::Portal_Pocket::Master_IP @ "\";");

%FileObject_File_Out.writeLine("$pref::Portal_Pocket::P2P_IP = \"" @ $pref::Portal_Pocket::P2P_IP @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::allowOpenGL =" SPC $pref::Video::allowOpenGL @ ";");

%FileObject_File_Out.writeLine("$pref::Video::appliedPref =" SPC $pref::Video::appliedPref @ ";");

%FileObject_File_Out.writeLine("$pref::Video::clipHigh =" SPC $pref::Video::clipHigh @ ";");

%FileObject_File_Out.writeLine("$pref::Video::defaultResolution = \"" @ $pref::Video::defaultResolution @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::defaultsRenderer = \"" @ $pref::Video::defaultsRenderer @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::defaultsVendor = \"" @ $pref::Video::defaultsVendor @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::deleteContext =" SPC $pref::Video::deleteContext @ ";");

%FileObject_File_Out.writeLine("$pref::Video::disableVerticalSync =" SPC $pref::Video::disableVerticalSync @ ";");

%FileObject_File_Out.writeLine("$pref::Video::displayDevice = \"" @ $pref::Video::displayDevice @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::fullScreen =" SPC $pref::Video::fullScreen @ ";");

%FileObject_File_Out.writeLine("$pref::Video::only16 =" SPC $pref::Video::only16 @ ";");

%FileObject_File_Out.writeLine("$pref::Video::preferOpenGL =" SPC $pref::Video::preferOpenGL @ ";");

%FileObject_File_Out.writeLine("$pref::Video::profiledRenderer = \"" @ $pref::Video::profiledRenderer @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::profiledVendor = \"" @ $pref::Video::profiledVendor @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::safeModeOn =" SPC $pref::Video::safeModeOn @ ";");

%FileObject_File_Out.writeLine("$pref::Video::windowedRes = \"" @ $pref::Video::windowedRes @ "\";");

%FileObject_File_Out.writeLine("$pref::Audio::sfxVolume =" SPC $pref::Audio::sfxVolume @ ";");

%FileObject_File_Out.writeLine("$pref::Audio::musicVolume =" SPC $pref::Audio::musicVolume @ ";");

%FileObject_File_Out.writeLine("$pref::T2D::imageAssetGlobalFilterMode = \"" @ $pref::T2D::imageAssetGlobalFilterMode @ "\";");

%FileObject_File_Out.writeLine("");

%FileObject_File_Out.close();

}
