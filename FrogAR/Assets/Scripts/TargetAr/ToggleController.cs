using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TargetAr
{
    public class ToggleController : MonoBehaviour
    {
        [SerializeField] private FrogController.OrganCategory organPoint;
        [SerializeField] private Toggle toggle;
        [SerializeField] private TextMeshProUGUI textTmp;
        [SerializeField] private FrogController frogController;
        private bool _currentValue;

        private void Start()
        {
            if (frogController == null)
            {
                frogController = FindObjectOfType<FrogController>();
            }
        }

        private void SetName()
        {
            textTmp.text = organPoint.ToString();
        }

        public void SetPointer(FrogController.OrganCategory point)
        {
            organPoint = point;
            SetName();
        }
        
        public void OnValueChange()
        {
            if (GetCurrentValue())
            {
                frogController.ActivateOrgansByCategory(organPoint);
                return;
            }
            frogController.DeactivateOrgansByCategory(organPoint);
        }

        private bool GetCurrentValue()
        {
            return _currentValue = toggle.isOn;
        }
    }
}
