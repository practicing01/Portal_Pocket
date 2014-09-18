function Class_Portal::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Ball"||%Colliding_Object.class$="Class_Ball_White")
{

if (%Colliding_Object.SceneObject_From_Teleporter==0)
{

%Colliding_Object.SceneObject_From_Teleporter=%this;

%Colliding_Object.Position=Vector2Mult(%Colliding_Object.Position,"-1 -1");

}
else
{

%Colliding_Object.SceneObject_To_Teleporter=%this;

}

}

}

function Class_Portal::onEndCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Ball"||%Colliding_Object.class$="Class_Ball_White")
{

if (%Colliding_Object.SceneObject_To_Teleporter==%this)
{

%Colliding_Object.SceneObject_From_Teleporter=0;

%Colliding_Object.SceneObject_To_Teleporter=0;

}

}

}
