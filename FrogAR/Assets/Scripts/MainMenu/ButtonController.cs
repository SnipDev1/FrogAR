using System.Collections;
using Effects;
using UnityEngine;

namespace MainMenu
{
    public class ButtonController : MonoBehaviour
    {
        [SerializeField] private int mainMenuSceneId = 0;
        [SerializeField] private int targetSceneId = 1;
        [SerializeField] private int spaceSceneId = 2;
        [SerializeField] private FadeEffect fadeEffect;

        
        public void OnTargetBtn()
        {
            StartCoroutine(TargetBtnIEnumerator());

        }

        public void OnSpaceBtn()
        {
            StartCoroutine(SpaceBtnIEnumerator());
        }
        public void OnMainMenuBtn()
        {
            StartCoroutine(MainMenuBtnIEnumerator());
        }
        
        private IEnumerator TargetBtnIEnumerator()
        {
            yield return StartCoroutine(fadeEffect.IncreaseOpacity());
            SceneController.LoadSceneAsync(targetSceneId);
        }

        private IEnumerator SpaceBtnIEnumerator()
        {
            yield return StartCoroutine(fadeEffect.IncreaseOpacity());
            SceneController.LoadSceneAsync(spaceSceneId);
        }
        private IEnumerator MainMenuBtnIEnumerator()
        {
            yield return StartCoroutine(fadeEffect.IncreaseOpacity());
            SceneController.LoadSceneAsync(mainMenuSceneId);
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