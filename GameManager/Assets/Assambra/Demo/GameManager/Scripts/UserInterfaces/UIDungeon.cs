using UnityEngine;
using Assambra.GameFramework.GameManager;

namespace Assambra.GameFramework.Demo.GameManager
{
    public class UIDungeon : MonoBehaviour
    {
        public void OnButtonBack()
        {
            GameManager.Instance.ChangeScene(Scenes.DemoWorld);
        }
    }
}
