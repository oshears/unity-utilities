using UnityEngine;

namespace OSGames.Utilities {
    public static class VectorExtensions {

        public static Vector3 GetXZVector(Vector3 vector){
            return new Vector3(vector.x, 0, vector.z);
        }

        public static Vector2 GetXZVector2(Vector3 vector){
            return new Vector3(vector.x, vector.z);
        }

    }
}