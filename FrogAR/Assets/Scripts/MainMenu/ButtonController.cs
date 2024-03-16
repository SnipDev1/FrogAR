using System.Collections;
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
            StartCoroutine(TargetBtnIEnumerator());

        }

        public void OnSpaceBtn()
        {
            StartCoroutine(SpaceBtnIEnumerator());
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