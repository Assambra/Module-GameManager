using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILogin : MonoBehaviour
{
    public void OnButtonWorld()
    {
        GameManager.Instance.ChangeScene(Scenes.DemoWorld);
    }
}
