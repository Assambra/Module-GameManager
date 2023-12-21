using System;
using System.Collections;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public static event Action<GameState> OnStateChanged;
    [field: SerializeField] public SceneHandler sceneHandler { get; private set; }
    
    [SerializeField] public GameState _currentState = GameState.None;
    [Tooltip("We need a small time delay so that we can use the OnStateChanged event in UI elements, as they are only being instantiated to use the event.")]
    [SerializeField] private float _timeDelayChangeGameState = 0.1f;

    private void OnEnable()
    {
        SceneHandler.OnSceneChanged += OnSceneChanged;
    }

    private void OnDisable()
    {
        SceneHandler.OnSceneChanged -= OnSceneChanged;
    }

    protected override void Awake()
    {
        base.Awake();
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

    public void ChangeState(GameState newState)
    {
        StartCoroutine(ChangeStateRoutine(newState));
    }

    IEnumerator ChangeStateRoutine(GameState newState)
    {
        yield return new WaitForSeconds(_timeDelayChangeGameState);

        if (_currentState != newState)
        {
            _currentState = newState;
            OnStateChanged?.Invoke(newState);
        }
    }

    public void ChangeScene(Scenes scene)
    {
        sceneHandler.CurrentScene = sceneHandler.Scenes[(int)scene];
    }

    private void OnSceneChanged()
    {
        //Debug.Log("Scene changed");
    }
}
