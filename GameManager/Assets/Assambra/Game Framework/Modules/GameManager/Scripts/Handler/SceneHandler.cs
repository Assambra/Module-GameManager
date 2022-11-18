using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    [Header("Objects and Scripts References")]
    [Space(5)]
    [SerializeField] private GameManager gameManager;

    // Private variables
    private GameState gameState;
    private GameState lastGameState;


    private void Awake()
    {
        if (gameManager == null)
            Debug.LogError("Error: No Scene Handler found");
    }

    private void Start()
    {
        lastGameState = gameState;
    }

    void Update()
    {
        gameState = gameManager.GameState;

        if (gameState != lastGameState)
        {
            lastGameState = gameState;

            switch (gameState)
            {
                //We switch direct from Start scene to Login Scene
                case GameState.Start:
                    // Nothing to do here
                    break;
                case GameState.Login:
                    SwitchScene(nameof(GameState.Login));
                    break;
                case GameState.CreateAccount:
                    SwitchScene(nameof(GameState.CreateAccount));
                    break;
                case GameState.CharacterSelection:
                    SwitchScene(nameof(GameState.CharacterSelection));
                    break;
                case GameState.CharacterCreation:
                    SwitchScene(nameof(GameState.CharacterCreation));
                    break;
                case GameState.BeginnerArea:
                    SwitchScene(nameof(GameState.BeginnerArea));
                    break;
                case GameState.World:
                    SwitchScene(nameof(GameState.World));
                    break;
                default:
                    Debug.LogError("Error: Unknown GameState");
                    break;
            }
        }
    }

    private void SwitchScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
