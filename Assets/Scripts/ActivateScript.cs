using UnityEngine;

public class ActivateScript : MonoBehaviour
{
    [SerializeField]
    private GameObject activateObject;

    public void ActivateObject()
    {
        activateObject.SetActive(true);
    }

    public void DeactivateObject()
    {
        activateObject.SetActive(false);
    }
}

