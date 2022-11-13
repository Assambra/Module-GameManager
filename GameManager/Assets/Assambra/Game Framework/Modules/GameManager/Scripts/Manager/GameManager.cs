using UnityEngine;

public class GameManager : MonoBehaviour
{
    [field: SerializeField] public GameState GameState { get; private set; }
    
    private void Awake()
    {
        GameState = GameState.Start;
    }

    void Start()
    {
        GameState = GameState.Login;
    }

    private void Update()
    {
        // Just in case someone try to set the GameState.Start
        if (GameState == GameState.Start)
            GameState = GameState.Login;
    }
}
