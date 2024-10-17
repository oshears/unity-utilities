using UnityEngine;
using UnityEditor;

#if UNITY_EDITOR
namespace OSGames.Utilities{

    public static class ContextMenuExtensions {

        // [ContextMenuItem("Paste Keep Position",OnPasteKeepPosition)]
        // string pasteKeepPosition;

        [MenuItem("OSGames/Paste Keep Position")]
        static void OnPasteKeepPosition() {
            // Selection.cu
            Debug.Log("Dummy Paste");
        }




    }
}
#endif