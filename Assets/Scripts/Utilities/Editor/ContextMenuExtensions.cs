using UnityEngine;
using UnityEditor;

#if UNITY_EDITOR
namespace OSGames.Utilities{

    public static class ContextMenuExtensions {

        [MenuItem("GameObject/Paste Keep Position")]
        static void OnPasteKeepPosition() {

            for(int i = 0; i < Selection.gameObjects.Length; i++){
                Debug.Log("Executed Paste Keep Position");
            }
        }
    }
}
#endif