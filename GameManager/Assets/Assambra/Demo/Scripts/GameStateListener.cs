using UnityEngine;
using UnityEngine.UI;

public class GameStateListener : MonoBehaviour
{
    [SerializeField] private GameManager gameManager = null;
    [SerializeField] Text textInfoGameState = null;

    private GameState gameState;
    
    private void Awake()
    {
        if (gameManager == null)
            Debug.LogError("No Game Manager reference are set");
    }

    void Update()
    {
        gameState = gameManager.GameState;

        switch (gameState)
        {
            //We switch direct from Start scene to Login Scene
            case GameState.Start:
                // Nothing to do here
                break;
            case GameState.Login:
                textInfoGameState.text = "GameState: Login";
                break;
            case GameState.CreateAccount:
                textInfoGameState.text = "GameState: CreateAccount";
                break;
            case GameState.CharacterSelection:
                textInfoGameState.text = "GameState: CharacterSelection";
                break;
            case GameState.CharacterCreation:
                textInfoGameState.text = "GameState: CharacterCreation";
                break;
            case GameState.BeginnerArea:
                textInfoGameState.text = "GameState: BeginnerArea";
                break;
            case GameState.World:
                textInfoGameState.text = "GameState: World";
                break;
            default:
                textInfoGameState.text = "Error: Unknown GameState";
                break;
        }
    }
}
