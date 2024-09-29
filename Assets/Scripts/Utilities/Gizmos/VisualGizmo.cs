
#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;

namespace OSGames.Utilities.Gizmos {

    public class VisualGizmo : MonoBehaviour
    {
        [SerializeField] public Color m_GizmoColor = Color.red;
        [SerializeField] public Vector3 m_GizmoSize = Vector3.one;
        [SerializeField] public Vector3 m_GizmosShapeOffset;
        [SerializeField] public string m_GizmoText = "Test Gizmo";
        [SerializeField] public Vector3 m_GizmoTextOffset;
        [SerializeField] public GizmoShape m_GizmoShape = GizmoShape.Sphere;
        [SerializeField] public bool m_ShowGizmo = true;
        [SerializeField] public BoxCollider boxCollider;
        [SerializeField] public SphereCollider sphereCollider;
        [SerializeField] public Direction m_ShowDirection;
        [SerializeField] public float m_DirectionLength = 1f;
        [SerializeField] public Color m_DirectionColor = Color.yellow;

        public enum GizmoShape
        {
            Cube,
            WireCube,
            Sphere,
            WireSphere
        }

        public enum Direction
        {
            None,
            Right,
            Left,
            Up,
            Down,
            Forward,
            Back
        }

        private void OnDrawGizmos()
        {
            if (!m_ShowGizmo) return;

            // Show base gizmo
            UnityEngine.Gizmos.color = m_GizmoColor;
            if (m_GizmoShape == GizmoShape.Cube)
            {
                UnityEngine.Gizmos.DrawCube(transform.position + m_GizmosShapeOffset, m_GizmoSize);
                if (boxCollider) UnityEngine.Gizmos.DrawCube(transform.position + boxCollider.center, boxCollider.size);
            }
            if (m_GizmoShape == GizmoShape.WireCube)
            {
                UnityEngine.Gizmos.DrawWireCube(transform.position + m_GizmosShapeOffset, m_GizmoSize);
                if (boxCollider) UnityEngine.Gizmos.DrawWireCube(transform.position + boxCollider.center, boxCollider.size);
            }
            if (m_GizmoShape == GizmoShape.Sphere)
            {
                UnityEngine.Gizmos.DrawSphere(transform.position + m_GizmosShapeOffset, m_GizmoSize.x);
                if (sphereCollider) UnityEngine.Gizmos.DrawSphere(transform.position + sphereCollider.center, sphereCollider.radius);
            }
            if (m_GizmoShape == GizmoShape.WireSphere)
            {
                UnityEngine.Gizmos.DrawWireSphere(transform.position + m_GizmosShapeOffset, m_GizmoSize.x);
                if (sphereCollider) UnityEngine.Gizmos.DrawWireSphere(transform.position + sphereCollider.center, sphereCollider.radius);
            }

            // Show direction
            DrawDirectionGizmo();

            // Show text
            Handles.Label(transform.position + m_GizmoTextOffset, m_GizmoText);
        }

        private void DrawDirectionGizmo()
        {
            if (m_ShowDirection == Direction.None) return;

            Vector3 startPoint = transform.position;
            Vector3 endPoint = startPoint;

            switch (m_ShowDirection)
            {
                case Direction.Right:
                    endPoint += transform.right * m_DirectionLength;
                    break;
                case Direction.Left:
                    endPoint -= transform.right * m_DirectionLength;
                    break;
                case Direction.Up:
                    endPoint += transform.up * m_DirectionLength;
                    break;
                case Direction.Down:
                    endPoint -= transform.up * m_DirectionLength;
                    break;
                case Direction.Forward:
                    endPoint += transform.forward * m_DirectionLength;
                    break;
                case Direction.Back:
                    endPoint -= transform.forward * m_DirectionLength;
                    break;
            }

            UnityEngine.Gizmos.color = m_DirectionColor;
            UnityEngine.Gizmos.DrawLine(startPoint, endPoint);
            UnityEngine.Gizmos.DrawSphere(endPoint, 0.1f * m_DirectionLength);
        }
        
    }
}
#endif