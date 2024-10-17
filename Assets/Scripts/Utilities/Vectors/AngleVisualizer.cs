using UnityEngine;

namespace OSGames.Utilities {
    public class VectorAngleVisualizer : MonoBehaviour{

        [SerializeField] Transform transformA;
        [SerializeField] Transform transformB;
        [SerializeField] Transform transformC;

        #if UNITY_EDITOR
        void OnDrawGizmos(){
            UnityEngine.Gizmos.DrawLine(transformA.position, transformB.position);
            UnityEngine.Gizmos.DrawLine(transformA.position, transformC.position);

            Vector2 reference = VectorExtensions.GetXZVector2(transformB.position - transformA.position);
            Vector2 measured = VectorExtensions.GetXZVector2(transformC.position - transformA.position);

            Debug.Log(Vector2.SignedAngle(reference, measured));
        }
        #endif
    }
}