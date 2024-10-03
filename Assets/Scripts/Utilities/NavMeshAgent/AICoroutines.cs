using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;


namespace OSGames.Utilities.AI {

    public static class AICoroutines {

        public static IEnumerator WaitNavMeshArrive(NavMeshAgent agent, Action method){
            bool arrived = false;
            while (!arrived){
                yield return new WaitForSeconds(0.1f);
                if (!agent.pathPending)
                {
                    if (agent.remainingDistance <= agent.stoppingDistance)
                    {
                        if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                        {
                            arrived = true;
                        }
                    }
                }
            }

            method();
        }

    }
    
}