using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    [Header("Objects and Scripts References")]
    [Space(5)]
    [SerializeField] private GameManager gameManager;


    // Private variables
    private SceneUI[] sceneUIs;
    private Dictionary<string, SceneUI> sceneUIsDictionary = new Dictionary<string, SceneUI>();
    private GameState gameState;
    private GameState lastGameState;

    private void Awake()
    {
        if (gameManager == null)
            Debug.LogError("Error: No OmniaSceneManager found");

        sceneUIs = GetComponentsInChildren<SceneUI>(true);

        foreach (SceneUI sceneUI in sceneUIs)
            sceneUIsDictionary.Add(sceneUI.gameObject.name, sceneUI);
    }

    private void Start()
    {
        lastGameState = gameState;
    }

    private void Update()
    {
        gameState = gameManager.GameState;

        if (gameState != lastGameState)
        {
            SceneUI sceneUI = null;

            //Disable last UI except last scene is Start
            if (lastGameState.ToString() != "Start")
            {
                sceneUIsDictionary.TryGetValue(lastGameState.ToString(), out sceneUI);
                sceneUI.ChangeActiveState();
            }

            lastGameState = gameManager.GameState;

            switch (gameState)
            {
                //We switch direct from Start scene to Login Scene
                case GameState.Start:
                    // Nothing to do here
                    break;
                case GameState.Login:
                    sceneUIsDictionary.TryGetValue(nameof(GameState.Login), out sceneUI);
                    sceneUI.ChangeActiveState();
                    break;
                case GameState.CreateAccount:
                    sceneUIsDictionary.TryGetValue(nameof(GameState.CreateAccount), out sceneUI);
                    sceneUI.ChangeActiveState();
                    break;
                case GameState.CharacterSelection:
                    sceneUIsDictionary.TryGetValue(nameof(GameState.CharacterSelection), out sceneUI);
                    sceneUI.ChangeActiveState();
                    break;
                case GameState.CharacterCreation:
                    sceneUIsDictionary.TryGetValue(nameof(GameState.CharacterCreation), out sceneUI);
                    sceneUI.ChangeActiveState();
                    break;
                case GameState.BeginnerArea:
                    sceneUIsDictionary.TryGetValue(nameof(GameState.BeginnerArea), out sceneUI);
                    sceneUI.ChangeActiveState();
                    break;
                case GameState.World:
                    sceneUIsDictionary.TryGetValue(nameof(GameState.World), out sceneUI);
                    sceneUI.ChangeActiveState();
                    break;
                default:
                    Debug.LogError("Error: Unknown GameState");
                    break;
            }
        }
    }
}
