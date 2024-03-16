using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TargetAr
{
    public class OrganCanvasController : MonoBehaviour
    {
        [SerializeField] private Image image;
        [SerializeField] private Canvas canvas;
        
        [SerializeField] private TextMeshProUGUI headerTmp;
        [SerializeField] private TextMeshProUGUI bodyTmp;

        private void Start()
        {
            if (canvas == null)
            {
                canvas = GetComponent<Canvas>();
            }
            HideCanvas();
        }

        public void SetCanvas(string headerText, string bodyText, Sprite logo)
        {
            SetHeader(headerText);
            SetBody(bodyText);
            SetImage(logo);
        }

        public void ShowCanvas()
        {
            canvas.enabled = true;
        }

        private void HideCanvas()
        {
            canvas.enabled = false;
        }

        public void OnHideButton()
        {
            HideCanvas();
        }

        private void SetHeader(string text)
        {
            headerTmp.text = text;
        }

        private void SetBody(string text)
        {   
            bodyTmp.text = text;
        }

        private void SetImage(Sprite sprite)
        {
            image.sprite = sprite;
        }
    }
}