using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDungeon : MonoBehaviour
{
    private SceneHandler sceneHandler;

    private void Awake()
    {
        sceneHandler = GameObject.FindObjectOfType<SceneHandler>();
    }

    public void OnButtonBack()
    {
        sceneHandler.CurrentScene = sceneHandler.Scenes[1];
    }
}
