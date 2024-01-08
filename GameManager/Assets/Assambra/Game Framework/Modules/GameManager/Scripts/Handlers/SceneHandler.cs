using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public List<Scene> Scenes = new List<Scene>();
    public Scene CurrentScene = null;
    public Scene LastScene = null;

    public delegate void SceneAction();
    public static event SceneAction OnSceneChanged;

    private void Awake()
    {
        foreach (Scene scene in Scenes)
        {
            if (scene.IsFirstScene)
                CurrentScene = scene;
        }
    }

    void Update()
    {
        if (CurrentScene != LastScene)
        {
            OnSceneChanged?.Invoke();

            foreach (Scene scene in Scenes)
            {
                if (scene == CurrentScene)
                {
                    foreach(SceneAsset sa in scene.scenes)
                    {
                        string scenePath = AssetDatabase.GetAssetPath(sa);
                        LoadSceneAsync(scenePath, LoadSceneMode.Additive);
                    }
                }
            }

            if (LastScene != null)
            {
                foreach(Scene scene in Scenes)
                {
                    if (scene == LastScene)
                    {
                        foreach (SceneAsset sa in scene.scenes)
                        {
                            string scenePath = AssetDatabase.GetAssetPath(sa);
                            UnloadSceneAsync(scenePath);
                        }
                    }
                }
            }

            LastScene = CurrentScene;
        }
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
