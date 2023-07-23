using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILogin : MonoBehaviour
{
    private SceneHandler sceneHandler;

    private void Awake()
    {
        sceneHandler = GameObject.FindObjectOfType<SceneHandler>();
    }

    public void OnButtonWorld()
    {
        sceneHandler.CurrentScene = sceneHandler.Scenes[1];
    }
}
