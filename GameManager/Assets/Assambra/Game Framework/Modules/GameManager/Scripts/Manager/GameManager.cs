using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [field: SerializeField] public SceneHandler sceneHandler { get; private set; }


    public void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;

        SceneHandler.OnSceneChanged += OnSceneChanged;
    }

    private void OnDestroy()
    {
        SceneHandler.OnSceneChanged -= OnSceneChanged;
    }

    public void ChangeScene(Scenes scene)
    {
        sceneHandler.CurrentScene = sceneHandler.Scenes[(int)scene];
    }

    private void OnSceneChanged()
    {
        Debug.Log("Scene changed");
    }
}
