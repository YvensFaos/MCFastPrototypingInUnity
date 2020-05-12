using UnityEngine;
using UnityEngine.Events;

public class EventHandler : MonoBehaviour
{
    [SerializeField]
    UnityEvent events;

    public void CallEvents()
    {
        events.Invoke();
    }
}


