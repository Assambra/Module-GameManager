using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] SceneHandler sceneHandler;
    [SerializeField] private Transform canvas;

    private List<GameObject> uIElements = new List<GameObject>();

    private void OnEnable()
    {
        SceneHandler.OnSceneChanged += SceneChanged;
    }

    private void OnDisable()
    {
        SceneHandler.OnSceneChanged -= SceneChanged;
    }

    private void SceneChanged()
    {
        HashSet<string> lastUIElements = new HashSet<string>();

        if (sceneHandler.LastScene != null)
        {
            lastUIElements = sceneHandler.LastScene.SceneUISets
                .SelectMany(set => set.UIElementPrefabs)
                .Select(obj => obj.name)
                .ToHashSet();
        }

        HashSet<string> currentUIElements = sceneHandler.CurrentScene.SceneUISets
            .SelectMany(set => set.UIElementPrefabs)
            .Select(obj => obj.name)
            .ToHashSet();

        foreach (var uIElement in uIElements.ToList())
        {
            if (!currentUIElements.Contains(uIElement.name))
            {
                Destroy(uIElement);
                uIElements.Remove(uIElement);
            }
        }

        foreach (var sceneUISet in sceneHandler.CurrentScene.SceneUISets)
        {
            foreach (var obj in sceneUISet.UIElementPrefabs)
            {
                if (sceneHandler.LastScene == null || !lastUIElements.Contains(obj.name))
                {
                    InstantiateCurrentSceneUI(obj);
                }
            }
        }
    }

    private void InstantiateCurrentSceneUI(GameObject obj)
    {
        GameObject go = Instantiate(obj, canvas);
        go.name = obj.name;
        uIElements.Add(go);
    }
}
