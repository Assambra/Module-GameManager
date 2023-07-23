using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWorld : MonoBehaviour
{
    private SceneHandler sceneHandler;
    
    private void Awake ()
    {
        sceneHandler = GameObject.FindObjectOfType<SceneHandler>();
    }

    public void OnButtonBack()
    {
        sceneHandler.CurrentScene = sceneHandler.Scenes[0];
    }

    public void OnButtonDungeon()
    {
        sceneHandler.CurrentScene = sceneHandler.Scenes[2];
    }
}
