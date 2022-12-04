using UnityEngine;

[CreateAssetMenu(fileName = "SetSceneUI", menuName = "Assambra/SetSceneUI", order = 1)]
[System.Serializable]
public class SceneUISet : ScriptableObject
{
    public GameObject[] UIElementPrefabs;
}
