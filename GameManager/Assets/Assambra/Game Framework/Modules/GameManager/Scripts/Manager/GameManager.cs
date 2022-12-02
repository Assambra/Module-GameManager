using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] public List<Scene> Scenes = new List<Scene>();
    [SerializeField] public Scene CurrentScene = null;
    [SerializeField] public Scene LastScene = null;

    private void Awake()
    {
        foreach (Scene scene in Scenes)
        {
            if (scene.IsPersistentScene)
            {
                CurrentScene = scene;
            }  
        }
    }

    private void Update()
    {
        // Just in case someone try to use the persistent scene
        if(CurrentScene.IsPersistentScene)
        {
            foreach (Scene scene in Scenes)
            {
                if(scene.IsFirstScene)
                    CurrentScene = scene;
            }
        }

        if (CurrentScene != LastScene && !CurrentScene.IsPersistentScene)
        {
            foreach (Scene scene in Scenes)
            {
                if (scene == CurrentScene)
                {
                    LoadSceneAsync(scene.ScenePath, LoadSceneMode.Additive);
                }
            }
            if (LastScene != null)
            {
                UnloadSceneAsync(LastScene.ScenePath);
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
