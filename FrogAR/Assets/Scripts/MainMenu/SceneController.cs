using Effects;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu
{
    public class SceneController : MonoBehaviour
    {
        [SerializeField] private FadeEffect fadeEffect;
        private void Start()
        {
            fadeEffect.StartEffect();
        }

        
        public static void LoadSceneAsync(int sceneIndex)
        {
            SceneManager.LoadSceneAsync(sceneIndex);
        }
    }
}
