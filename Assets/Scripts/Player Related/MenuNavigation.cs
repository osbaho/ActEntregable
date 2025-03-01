using UnityEngine;
using UnityEngine.EventSystems;

public class MenuNavigation : MonoBehaviour
{
    [SerializeField] private GameObject defaultSelectedObject;
    private void Start()
    {
        EventSystem.current.SetSelectedGameObject(defaultSelectedObject);
    }

    private void Update()
    {
        if (EventSystem.current.currentSelectedGameObject == null)
        {
            EventSystem.current.SetSelectedGameObject(defaultSelectedObject);
        }
    }
}
