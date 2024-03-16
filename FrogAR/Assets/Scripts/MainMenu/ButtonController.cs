using Effects;
using UnityEngine;

namespace MainMenu
{
    public class ButtonController : MonoBehaviour
    {
        [SerializeField] private int targetSceneId = 1;
        [SerializeField] private int spaceSceneId = 2;
        [SerializeField] private FadeEffect fadeEffect;
        
        public void OnTargetBtn()
        {
            SceneController.LoadSceneAsync(targetSceneId);
        }

        public void OnSpaceBtn()
        {
            SceneController.LoadSceneAsync(spaceSceneId);

        }

        public void IncreaseAnimation()
        {
            StartCoroutine(fadeEffect.IncreaseOpacity());
            
        }
        public void DecreaseAnimation()
        {
            StartCoroutine(fadeEffect.DecreaseOpacity());
        }
    }
}
