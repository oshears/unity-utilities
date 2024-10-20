using UnityEngine;

namespace OSGames.Utilities{
    
    public class Billboard : MonoBehaviour {

        [Tooltip("The additional offset angle to adjust the billboard effect.")]
        [SerializeField] Vector3 m_AngleOffset;

        void Update(){
            transform.LookAt(Camera.main.transform.position, -Vector3.up);
            transform.eulerAngles += m_AngleOffset;
        }
        
    }
}