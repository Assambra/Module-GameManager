using UnityEngine;

public class UIDungeon : MonoBehaviour
{
    public void OnButtonBack()
    {
        GameManager.Instance.ChangeScene(Scenes.DemoWorld);
    }
}
