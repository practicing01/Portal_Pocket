function Class_Portal_Pocket_Input_Controller::onMouseWheelUp(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

SceneWindow_Portal_Pocket.setCameraZoom(SceneWindow_Portal_Pocket.getCameraZoom()+$pref::Portal_Pocket::cameraMouseZoomRate);

}

function Class_Portal_Pocket_Input_Controller::onMouseWheelDown(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

SceneWindow_Portal_Pocket.setCameraZoom(SceneWindow_Portal_Pocket.getCameraZoom()-$pref::Portal_Pocket::cameraMouseZoomRate);

}
