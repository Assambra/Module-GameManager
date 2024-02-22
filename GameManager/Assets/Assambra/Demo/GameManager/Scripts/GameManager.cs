using UnityEngine;

public class GameManager : BaseGameManager
{
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }

    private void Start()
    {
        ChangeState(GameState.Lobby);
    }

    private void Update()
    {
        switch (_currentState)
        {
            case GameState.Lobby:
                Debug.Log("GameManager::Update() Demo GameState Lobby");
                break;
            case GameState.Game:
                Debug.Log("GameManager::Update() Demo GameState Game");
                break;
        }
    }

    protected override void OnSceneChanged(Scene lastScene, Scene newScene)
    {
        Debug.Log("GameManager::OnSceneChanged(), Demo do something if the scene are changed");
    }
}
