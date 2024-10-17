
#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;

namespace OSGames.Utilities.Gizmos {

    public static class GizmoUtilities {
        public static void DrawLine(Transform pointA, Transform pointB){
            UnityEngine.Gizmos.DrawLine(pointA.position, pointB.position);
        }

        public static void DrawLine(Transform pointA, Transform pointB, Color color){
            UnityEngine.Gizmos.color = color;
            DrawLine(pointA, pointB);
        }

        public static void DrawSphere(Transform pointA, float radius){
            UnityEngine.Gizmos.DrawSphere(pointA.position, radius);
        }

        public static void DrawSphere(Transform pointA, float radius, Color color){
            UnityEngine.Gizmos.color = color;
            DrawSphere(pointA, radius);
        }


    }


}

#endif