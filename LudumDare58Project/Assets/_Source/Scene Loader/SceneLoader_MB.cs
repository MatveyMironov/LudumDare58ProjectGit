using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader_MB : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
