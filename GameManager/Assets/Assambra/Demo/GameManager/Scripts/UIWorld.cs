using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWorld : MonoBehaviour
{
    public void OnButtonBack()
    {
        GameManager.Instance.ChangeScene(Scenes.DemoLogin);
    }

    public void OnButtonDungeon()
    {
        GameManager.Instance.ChangeScene(Scenes.DemoDungeon);
    }
}
