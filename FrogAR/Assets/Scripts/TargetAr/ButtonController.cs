using System.Collections;
using Effects;
using UnityEngine;

namespace TargetAr
{
    public class ButtonController: MonoBehaviour
    {
        [SerializeField] private FrogController frogController;
        [SerializeField] private FadeEffect fadeEffect;
        
        public void OnNext()
        {
            StartCoroutine(OnNextButton());
        }
        public void OnPrevious()
        {
            StartCoroutine(OnPreviousButton());

        }
        
        private IEnumerator OnNextButton()
        {
            yield return StartCoroutine(fadeEffect.IncreaseOpacity());
            frogController.OnNext();
            yield return StartCoroutine(fadeEffect.DecreaseOpacity());
        }

        private IEnumerator OnPreviousButton()
        {
            yield return StartCoroutine(fadeEffect.IncreaseOpacity());
            frogController.OnPrevious();
            yield return StartCoroutine(fadeEffect.DecreaseOpacity());
        }
    }
}