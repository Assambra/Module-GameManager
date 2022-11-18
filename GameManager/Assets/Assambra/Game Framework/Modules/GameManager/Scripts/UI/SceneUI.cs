using UnityEngine;

public class SceneUI : MonoBehaviour
{
    [Header("Objects and Scripts References")]
    [Space(5)]
    /// <summary>
    /// The UI element we work with.
    /// </summary>
    [Tooltip("The UI element we work with.")]
    [SerializeField] private GameObject uIElement = null;


    private void Awake()
    {
        if (uIElement == null)
            Debug.LogError("Error: No UI Element found! Setup the UI Element.");
    }

    /// <summary>
    /// Change the active state of the UI element, e.g. if it is activated it will be deactivated and vice versa
    /// </summary>
    public void ChangeActiveState()
    {
        uIElement.SetActive(!uIElement.activeSelf);
    }
}
