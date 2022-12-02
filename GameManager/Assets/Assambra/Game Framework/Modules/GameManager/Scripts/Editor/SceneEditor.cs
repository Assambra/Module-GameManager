using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Scene), true)]
public class SceneEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var scene = target as Scene;
        var oldScene = AssetDatabase.LoadAssetAtPath<SceneAsset>(scene.ScenePath);

        serializedObject.Update();

        EditorGUI.BeginChangeCheck();
        var newScene = EditorGUILayout.ObjectField("Scene", oldScene, typeof(SceneAsset), false) as SceneAsset;

        if (EditorGUI.EndChangeCheck())
        {
            var newPath = AssetDatabase.GetAssetPath(newScene);
            var scenePathProperty = serializedObject.FindProperty("ScenePath");
            scenePathProperty.stringValue = newPath;
        }

        scene.IsPersistentScene = EditorGUILayout.Toggle("Is Persistent Scene", scene.IsPersistentScene);
        scene.IsFirstScene = EditorGUILayout.Toggle("Is First Scene", scene.IsFirstScene);
        scene.SceneUIPrefab = (GameObject)EditorGUILayout.ObjectField("Scene UI Prefab",scene.SceneUIPrefab, typeof(GameObject), true);

        serializedObject.ApplyModifiedProperties();
    }
}
