function Module_Portal_Pocket::Scene_Initialize(%this)
{

for (%x=0;%x<Scene_Portal_Pocket.getCount();%x++)
{

%Object=Scene_Portal_Pocket.getObject(%x);

if (%Object.class$="Class_Ball"||%Object.class$="Class_Ball_White")
{

%Object.clearCollisionShapes();

%Int_CollisionShape_Index=%Object.createCircleCollisionShape(%Object.Size.X*0.5);

%Object.setCollisionShapeIsSensor(%Int_CollisionShape_Index,false);

%Object.setCollisionShapeRestitution(%Int_CollisionShape_Index,1);

%Object.setCollisionShapeDensity(%Int_CollisionShape_Index,1);

%Object.setCollisionShapeFriction(%Int_CollisionShape_Index,1);

%Object.setLinearDamping(0.7);

%Object.setAngularDamping(0.5);

%Object.SceneObject_From_Teleporter=0;

%Object.SceneObject_To_Teleporter=0;

%Object.setBullet(true);

%Object.Vector2D_Origin=%Object.Position;

if (%Object.class$="Class_Ball_White")
{

%this.Sprite_White_Ball=%Object;

}

}

}

}
