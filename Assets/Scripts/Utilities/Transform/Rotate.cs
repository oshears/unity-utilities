using UnityEngine;

namespace OSGames.Utilities{
    public class Rotate : MonoBehaviour
    {
        [SerializeField,Tooltip("Speed of the rotation.")]
        float m_RotationSpeed = 1;

        void Update(){
            float angle = m_RotationSpeed * UnityEngine.Time.deltaTime;
            transform.Rotate(0,angle,0);
        }
    }
}
