using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    [SerializeField] private List<Scene> scenes = new List<Scene>();
    public Scene CurrentScene = null;
    public Scene LastScene = null;

    [SerializeField] private Transform canvas;

    private void Awake()
    {
        foreach (Scene scene in scenes)
        {
            if (scene.IsFirstScene)
            {
                CurrentScene = scene;
            }
        }
    }

    private void Update()
    {
        if (CurrentScene != LastScene)
        {
            foreach (Scene scene in scenes)
            {
                if (scene == CurrentScene)
                {
                    LoadSceneAsync(scene.ScenePath, LoadSceneMode.Additive);
                    scene.InstantiateSceneUI(canvas);
                }  
            }
            if (LastScene != null)
            {
                UnloadSceneAsync(LastScene.ScenePath);
                LastScene.DestroySceneUI();
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
