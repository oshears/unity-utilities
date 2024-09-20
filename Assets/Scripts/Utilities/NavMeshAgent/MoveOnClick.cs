using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

namespace OSGames.Utilities.AI {

    public class MoveOnClick : MonoBehaviour {

        [SerializeField] NavMeshAgent m_Agent;

        Ray ray;

        Vector3 destination;

        void Start() {

        }

        
        void Update(){
            if (Input.GetKeyDown(KeyCode.Mouse0)){
                ray = Camera.main.ScreenPointToRay (Input.mousePosition);
                // RaycastHit hitInfo;
                // Debug.DrawRay(ray.origin,ray.direction);
                RaycastHit[] hits = Physics.RaycastAll(ray.origin, ray.direction);
                foreach (RaycastHit hitInfo in hits){
                    // Debug.Log (hitInfo);
                    // Debug.Log (hitInfo.transform.name);
                    // Vector3 movePosition;
                    // m_Agent.SetDestination(movePosition);
                    m_Agent.SetDestination(hitInfo.point);
                    destination = hitInfo.point;
                }
                
            }
        }

        void OnDrawGizmos() {
            Gizmos.DrawRay(ray.origin,ray.direction);
            Gizmos.DrawLine(ray.origin,ray.origin + 500*ray.direction);
            Gizmos.DrawSphere(destination,1);
        }
    }
}
