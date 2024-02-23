using UnityEngine;
using Assambra.GameFramework.GameManager;

namespace Assambra.GameFramework.Demo.GameManager
{
    public class UIWorld : MonoBehaviour
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
                case GameState.Game:
                    OnGameStateGame();
                    break;
            }
        }

        private void OnGameStateGame()
        {
            Debug.Log("UIWorld::OnGameStateGame() Demo Game State Machine");
        }

        #region BUTTON ONCLICK HANDLER

        public void OnButtonBack()
        {
            GameManager.Instance.ChangeState(GameState.Lobby);
            GameManager.Instance.ChangeScene(Scenes.DemoLogin);
        }

        public void OnButtonDungeon()
        {
            GameManager.Instance.ChangeScene(Scenes.DemoDungeon);
        }

        #endregion
    }
}
