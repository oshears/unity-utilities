using UnityEngine;
using DG;
using DG.Tweening;

namespace OSGames.Utilities {

    public class Sway : MonoBehaviour {

        [Range(0.1f,10f)]
        [SerializeField] float m_Duration;
        // [SerializeField] float m_Duration;

        Vector3 m_InitialPosition;
        
        void Start(){
            m_InitialPosition = transform.position;
            StartSway();
        }

        void StartSway(){
            Vector3 swayDestination = m_InitialPosition + Random.insideUnitSphere;
            transform.DOMove(swayDestination,m_Duration).OnComplete(OnSwayDone);
        }

        void OnSwayDone(){
            StartSway();
        }
        
    }

}