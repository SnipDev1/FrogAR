using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu
{
    public abstract class SceneController : MonoBehaviour
    {
        public static void LoadSceneAsync(int sceneIndex)
        {
            SceneManager.LoadSceneAsync(sceneIndex);
        }
    }
}
