function Class_Pocket::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object!=Module_Portal_Pocket.Sprite_White_Ball)
{

Module_Portal_Pocket.Int_Pocketed_Count++;

%Colliding_Object.setLinearVelocity("0 0");

%Colliding_Object.setAngularVelocity("0 0");

%Colliding_Object.Visible=false;

%Colliding_Object.Active=false;

}

if (Module_Portal_Pocket.Int_Pocketed_Count==15)
{

Module_Portal_Pocket.Int_Pocketed_Count=0;

for (%x=0;%x<Scene_Portal_Pocket.getCount();%x++)
{

%Object=Scene_Portal_Pocket.getObject(%x);

if (%Object.class$="Class_Ball"||%Object.class$="Class_Ball_White")
{

%Object.Visible=true;

%Object.Active=true;

%Object.setLinearVelocity("0 0");

%Object.setAngularVelocity("0 0");

%Object.Position=%Object.Vector2D_Origin;

}

}

}

}
