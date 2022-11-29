using UnityEngine;

public class GameManager : MonoBehaviour
{
    [field: SerializeField] public GameState GameState { get; private set; }
    
    private void Awake()
    {
        GameState = GameState.Persistent;
    }

    void Start()
    {
        GameState = GameState.Login;
    }

    private void Update()
    {
        // Just in case someone try to set the GameState.Persistent
        if (GameState == GameState.Persistent)
            GameState = GameState.Login;
    }
}
