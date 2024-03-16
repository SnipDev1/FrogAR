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
            panelImage.color =  new Color(0, 0, 0, _opacity);
        }


        public IEnumerator IncreaseOpacity()
        {
            Debug.Log("Increasing Started");
            while (GetOpacity() < endOpacity)
            {
                // Debug.Log(GetOpacity());
                _opacity += fadeSpeed * Time.deltaTime;
                panelImage.color = new Color(0, 0, 0, _opacity);
                yield return null;
            }

            _opacity = endOpacity;
        }

        public IEnumerator DecreaseOpacity()
        {
            Debug.Log("Decreasing Started");

            while (GetOpacity() >= startOpacity)
            {
                // Debug.Log(GetOpacity());
                _opacity -= fadeSpeed * Time.deltaTime;
                panelImage.color = new Color(0, 0, 0, _opacity);
                yield return null;
            }


            _opacity = startOpacity;
        }

        /*
        private IEnumerator SetZeroOpacity()
        {
            if (GetOpacity() < 0f)
            {
                while (GetOpacity() <= 0f)
                {
                    _colorAdjustments.postExposure.value += fadeSpeed * Time.deltaTime;
                    yield return null;
                }

                _colorAdjustments.postExposure.value = 0f;
            }
            else if (GetOpacity() > 0f)
            {
                while (GetOpacity() >= 0f)
                {
                    _colorAdjustments.postExposure.value -= fadeSpeed * Time.deltaTime;
                    yield return null;
                }

                _colorAdjustments.postExposure.value = 0f;
            }

            // StopCoroutine(nameof(SetZeroOpacity));
        }
        */
        private float GetOpacity()
        {
            return _opacity;
        }
    }
}