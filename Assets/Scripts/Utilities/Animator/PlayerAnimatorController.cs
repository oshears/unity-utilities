using UnityEngine;

namespace OSGames.Utilities.Animations {
    public class NavMeshAgentAnimator : MonoBehaviour {
        

        [SerializeField] UnityEngine.AI.NavMeshAgent m_Agent;
        [SerializeField] Animator m_Animator;

        void Update(){
            m_Animator.SetFloat("Speed",m_Agent.velocity.magnitude);
        }
    }
}