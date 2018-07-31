using System.Collections;

using UnityEngine;

public static class Extensions{
    public static Vector2 toVector2 (this Vector3 Vec3){
        return new Vector2(Vec3.x, Vec3.y);
    }
}

    
