using System.Collections.Generic;
using UnityEngine;

namespace Assambra.GameFramework.GameManager
{
    [CreateAssetMenu(fileName = "Scene", menuName = "Assambra/Scene", order = 1)]
    public class Scene : ScriptableObject
    {
        public string ScenePath;

        public bool IsFirstScene = false;

        [SerializeField] public List<SceneUISet> SceneUISets = new List<SceneUISet>();
    }
}
