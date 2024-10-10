using UnityEngine;

namespace OSGames.Utilities {
    public static class VectorExtensions {

        public static Vector3 GetXZVector(Vector3 vector){
            return new Vector3(vector.x, 0, vector.y);
        }

    }
}