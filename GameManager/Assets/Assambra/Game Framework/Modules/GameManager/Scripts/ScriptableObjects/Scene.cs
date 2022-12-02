using UnityEngine;

[CreateAssetMenu(fileName = "Scene", menuName = "Assambra/Scene", order = 1)]
public class Scene : ScriptableObject
{
    public string ScenePath;

    public bool IsFirstScene = false;
    public GameObject SceneUIPrefab = null;
}
