using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

#if UNITY_EDITOR
namespace OSGames.Utilities {
    public class UtilityEditorWindow : EditorWindow
    {

        string baseObjectName;

        TextField baseNameField;

        [MenuItem("Utilities/Utility Menu")]
        public static void ShowWindow()
        {
            UtilityEditorWindow wnd = GetWindow<UtilityEditorWindow>();
            wnd.titleContent = new GUIContent("Utility Menu");
        }

        void CreateGUI()
        {
            
            Button renameButton = new Button();
            renameButton.text = "Rename Selected";
            renameButton.tooltip = "Base name for the selected objects";
            renameButton.clicked += () => {
                for(int i = 0; i < Selection.objects.Length; i++) {
                    Selection.objects[i].name = $"{baseNameField.text} ({i})";
                }
            };
            rootVisualElement.Add(renameButton);

            baseNameField = new TextField();
            rootVisualElement.Add(baseNameField);

        }
    }
}
#endif