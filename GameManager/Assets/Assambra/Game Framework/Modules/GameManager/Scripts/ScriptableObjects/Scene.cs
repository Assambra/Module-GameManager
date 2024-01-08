using UnityEngine;
using System.Collections.Generic;
using UnityEditor;

[CreateAssetMenu(fileName = "Scene", menuName = "Assambra/Scene", order = 1)]
public class Scene : ScriptableObject
{
    public bool IsFirstScene = false;

    [SerializeField] public List<SceneAsset> scenes = new List<SceneAsset>();
    
    public List<SceneUISet> SceneUISets = new List<SceneUISet>();
}
