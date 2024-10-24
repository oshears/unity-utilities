using UnityEngine;
using UnityEngine.EventSystems;

namespace OSGames.Utilities {
    public class EventSystemLogger : MonoBehaviour
    {

        void Awake(){
            
        }

        void Update(){
            if (EventSystem.current.currentSelectedGameObject != null){
                Debug.Log($"Event System is selecting: {EventSystem.current.currentSelectedGameObject.name}",EventSystem.current.currentSelectedGameObject);
            }
        }
        
    }
}