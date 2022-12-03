using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Scene", menuName = "Assambra/Scene", order = 1)]
public class Scene : ScriptableObject
{
    public string ScenePath;

    public bool IsFirstScene = false;
    public SceneUI SceneUI;

    private List<GameObject> uIElements = new List<GameObject>();
    
    public void InstantiateSceneUI(Transform transform)
    {
        Debug.Log(" InstantiateSceneUI()");
        uIElements.Clear();
        foreach(GameObject uIElement in SceneUI.UIElementPrefabs)
        {
            GameObject go = Instantiate(uIElement, transform);
            uIElements.Add(go);
        }
    }

    public void DestroySceneUI()
    {
        Debug.Log("DestroySceneUI()");
        foreach (GameObject uIElement in uIElements)
        {
            Destroy(uIElement);
        }
    }
}
