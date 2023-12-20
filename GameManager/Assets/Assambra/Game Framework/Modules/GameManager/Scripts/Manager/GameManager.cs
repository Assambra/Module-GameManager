using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [field: SerializeField] public SceneHandler sceneHandler { get; private set; }


    protected override void Awake()
    {
        base.Awake();

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
