using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class RemoveMyRenderer : MonoBehaviour
{
    void Awake()
    {
        GetComponent<Renderer>().enabled = false;
    }
}

