using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;


namespace OSGames.Utilities.Time {
    public static class TimeCoroutines {
        public static IEnumerator ExecuteAfterDelay(float delay, Action action){
            yield return new WaitForSeconds(delay);
            action();
        }
    }
}