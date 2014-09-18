//-----------------------------------------------------------------------------
// Copyright (c) 2013 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

/// Game
$Game::CompanyName              = "MourningDoveSoft";
$Game::ProductName              = "Portal_Pocket Game";

//hello world settings
$pref::Portal_Pocket::defaultBackgroundColor = "Black";
$pref::Portal_Pocket::metricsOption   = false;
$pref::Portal_Pocket::fpsmetricsOption = true;
$pref::Portal_Pocket::jointsOption    = false;
$pref::Portal_Pocket::wireframeOption = false;
$pref::Portal_Pocket::aabbOption      = false;
$pref::Portal_Pocket::oobbOption      = false;
$pref::Portal_Pocket::sleepOption     = false;
$pref::Portal_Pocket::collisionOption = false;
$pref::Portal_Pocket::positionOption  = false;
$pref::Portal_Pocket::sortOption      = false;
$pref::Portal_Pocket::cameraMouseZoomRate = 0.01;
$pref::Portal_Pocket::cameraTouchZoomRate = 0.001;

/// iOS
$pref::iOS::ScreenOrientation   = $iOS::constant::Landscape;
$pref::iOS::ScreenDepth		    = 32;
$pref::iOS::UseGameKit          = 0;
$pref::iOS::UseMusic            = 0;
$pref::iOS::UseMoviePlayer      = 0;
$pref::iOS::UseAutoRotate       = 1;
$pref::iOS::EnableOrientationRotation = 1;
$pref::iOS::EnableOtherOrientationRotation = 1;   
$pref::iOS::StatusBarType       = 0;

/// Audio
$pref::Audio::driver = "OpenAL";
$pref::Audio::forceMaxDistanceUpdate = 0;
$pref::Audio::environmentEnabled = 0;
$pref::Audio::masterVolume   = 1.0;
$pref::Audio::channelVolume1 = 1.0;
$pref::Audio::channelVolume2 = 1.0;
$pref::Audio::channelVolume3 = 1.0;
$pref::Audio::sfxVolume = 1.0;
$pref::Audio::musicVolume = 1.0;

/// T2D
$pref::T2D::ParticlePlayerEmissionRateScale = 1.0;
$pref::T2D::ParticlePlayerSizeScale = 1.0;
$pref::T2D::ParticlePlayerForceScale = 1.0;
$pref::T2D::warnFileDeprecated = 1;
$pref::T2D::warnSceneOccupancy = 1;

/// Video
$pref::Video::appliedPref = 0;
$pref::Video::disableVerticalSync = 1;
$pref::Video::displayDevice = "OpenGL";
$pref::Video::preferOpenGL = 1;
$pref::Video::fullScreen = 0;
$pref::Video::defaultResolution = "800 480";
$pref::Video::windowedRes = "800 480 32";
$pref::OpenGL::gammaCorrection = 0.5;

/// Fonts.
$Gui::fontCacheDirectory = expandPath( "^Portal_Pocket/fonts" );
