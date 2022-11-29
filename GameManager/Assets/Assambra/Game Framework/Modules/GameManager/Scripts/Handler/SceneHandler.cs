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
            Debug.LogError("Error: No Game Manager found");
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
                case GameState.Persistent:
                    LoadSceneAsync(nameof(GameState.Persistent), LoadSceneMode.Single);
                    break;
                case GameState.Login:
                    LoadSceneAsync(nameof(GameState.Login), LoadSceneMode.Additive);
                    break;
                case GameState.CreateAccount:
                    LoadSceneAsync(nameof(GameState.CreateAccount), LoadSceneMode.Additive);
                    break;
                case GameState.CharacterSelection:
                    LoadSceneAsync(nameof(GameState.CharacterSelection), LoadSceneMode.Additive);
                    break;
                case GameState.CharacterCreation:
                    LoadSceneAsync(nameof(GameState.CharacterCreation), LoadSceneMode.Additive);
                    break;
                case GameState.BeginnerArea:
                    LoadSceneAsync(nameof(GameState.BeginnerArea), LoadSceneMode.Additive);
                    break;
                case GameState.World:
                    LoadSceneAsync(nameof(GameState.World), LoadSceneMode.Additive);
                    break;
                default:
                    Debug.LogError("Error: Unknown GameState");
                    break;
            }
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
