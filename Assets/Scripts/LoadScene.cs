using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
    public void Load(string sceneToBeLoaded)
    {
        SceneManager.LoadScene(sceneToBeLoaded);
    }
}



