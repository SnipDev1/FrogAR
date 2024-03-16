using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


namespace TargetAr
{
    public class ObjectController : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textMeshProUGUI;
        [SerializeField] private List<OrganController.Organs> organsList = new();
        private OrganCanvasController _organCanvasController;


        public void SetList(OrganController.Organs organs)
        {
            _organCanvasController = FindObjectOfType<OrganCanvasController>();
            organsList.Add(organs);
        }

        public void OnClick()
        {
            Debug.Log(organsList[0].organName);
            _organCanvasController.SetCanvas(organsList[0].organName, organsList[0].organDescription, organsList[0].organImage);
            _organCanvasController.ShowCanvas();
        }
        public void SetText(string text)
        {
            textMeshProUGUI.text = text;
        }
    }
}
