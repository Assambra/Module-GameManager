using UnityEngine;

public class UILogin : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.OnStateChanged += HandleStateChange;
    }

    private void OnDisable()
    {
        GameManager.OnStateChanged -= HandleStateChange;
    }

    private void HandleStateChange(GameState newState)
    {
        switch (newState)
        {
            case GameState.Lobby:
                OnGameStateLobby();
                break;
        }
    }

    private void OnGameStateLobby()
    {
        Debug.Log("UILogin::OnGameStateLobby() Demo Game State Machine");
    }

    #region BUTTON ONCLICK HANDLER

    public void OnButtonWorld()
    {
        GameManager.Instance.ChangeState(GameState.Game);
        GameManager.Instance.ChangeScene(Scenes.DemoWorld);
    }

    #endregion
}
