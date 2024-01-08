using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneHandler : MonoBehaviour
{
    public static event Action<Scene, Scene> OnSceneChanged;

    public List<Scene> Scenes = new List<Scene>();

    private Scene lastScene = null;

    private void Awake()
    {
        ChangeScene(GetFirstScene());
    }

    public void ChangeScene(Scene newScene)
    {
        if (lastScene != newScene)
        {
            OnSceneChanged?.Invoke(lastScene, newScene);
            UnloadScenesInSceneObject(lastScene);
            LoadScenesInSceneObject(newScene);
            lastScene = newScene;
        }
    }

    private void LoadScenesInSceneObject(Scene scene)
    {
        if (scene != null)
        {
            foreach (SceneAsset sa in scene.scenes)
            {
                string scenePath = AssetDatabase.GetAssetPath(sa);
                LoadSceneAsync(scenePath, LoadSceneMode.Additive);
            }
        }
    }

    private void UnloadScenesInSceneObject(Scene scene)
    {
        if (scene != null)
        {
            foreach (SceneAsset sa in scene.scenes)
            {
                string scenePath = AssetDatabase.GetAssetPath(sa);
                UnloadSceneAsync(scenePath);
            }
        }
    }

    private Scene GetFirstScene()
    {
        return Scenes.Find(scene => scene.IsFirstScene);
    }

    private void LoadSceneAsync(string scene, LoadSceneMode mode)
    {
        SceneManager.LoadSceneAsync(scene, mode);
    }

    private void UnloadSceneAsync(string scene)
    {
        SceneManager.UnloadSceneAsync(scene);
    }
}