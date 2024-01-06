using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : BaseGameManager
{
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
}
