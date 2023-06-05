using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GlobalInfo : EditorWindow
{

    private static Skill target;
    private static SerializedObject serializedObject;
    private static SerializedProperty listProperty;

    [MenuItem("Window/Static Variables")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(GlobalInfo));
    }
    private void OnEnable()
    {
        target = FindObjectOfType<Skill>();

        serializedObject = new SerializedObject(target);
        listProperty = serializedObject.FindProperty("skills");
    }

    private void OnGUI()
    {
        // Update the serialized object with the latest changes
        serializedObject.Update();

        // Display the static list in the inspector
        EditorGUILayout.PropertyField(listProperty, true);

        // Apply the modified values to the static list
        serializedObject.ApplyModifiedProperties();
    }
}
