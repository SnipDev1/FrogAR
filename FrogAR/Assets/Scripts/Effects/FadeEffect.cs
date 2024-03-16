using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Effects
{
    public class FadeEffect : MonoBehaviour
    {
        [SerializeField] private Image panelImage;

        [SerializeField] private float startOpacity = -10f;
        [SerializeField] private float endOpacity = 10f;
        [SerializeField] private float fadeSpeed = 1f;
        private float _opacity;

        private void Start()
        {
            SetImageOpacity(_opacity);
        }


        public IEnumerator IncreaseOpacity()
        {
            Debug.Log("Increasing Started");
            while (GetOpacity() < endOpacity)
            {
                _opacity += fadeSpeed * Time.deltaTime;
                SetImageOpacity(_opacity);
                yield return null;
            }
            Debug.Log("Increasing stopped");

            _opacity = endOpacity;
        }

        public IEnumerator DecreaseOpacity()
        {
            Debug.Log("Decreasing Started");

            while (GetOpacity() >= startOpacity)
            {
                _opacity -= fadeSpeed * Time.deltaTime;
                SetImageOpacity(_opacity);
                yield return null;
            }
            Debug.Log("Decreasing stopped");

            _opacity = startOpacity;
        }

        public void StartEffect()
        {
            SetImageOpacity(1);
            _opacity = 1;
            StartCoroutine(DecreaseOpacity());
        }
        
        private void SetImageOpacity(float alpha)
        {
            panelImage.color =  new Color(0, 0, 0, alpha);
        }
        private float GetOpacity()
        {
            return _opacity;
        }
    }
}