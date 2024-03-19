using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace TargetAr
{
    public class FrogController : MonoBehaviour
    {
        [Serializable]
        public class Organ
        {
            public string organName;
            public GameObject organObj;
        }

        [SerializeField] private TextMeshPro textMeshPro;
        [SerializeField] private List<Organ> organsList = new();
        private int _cursor;

        private void Start()
        {
            DeactivateAllObjects();
            ActivateObjectByIndex(0);
        }
        

        private void DeactivateAllObjects()
        {
            foreach (var organ in organsList)
            {
                organ.organObj.SetActive(false);
            }
        }

        private void ActivateObjectByIndex(int index)
        {
            organsList[index].organObj.SetActive(true);
            SetText(organsList[index].organName);
        }

        private void SetText(string text)
        {
            textMeshPro.text = text;
        }

        private void NextObject()
        {
            if (_cursor + 1 < organsList.Count)
            {
                organsList[_cursor].organObj.SetActive(false);
                _cursor++;
                ActivateObjectByIndex(_cursor);
            }
            else
            {
                organsList[_cursor].organObj.SetActive(false);
                _cursor = 0;
                ActivateObjectByIndex(_cursor);
            }
        }

        private void PreviousObject()
        {
            if (_cursor > 0)
            {
                organsList[_cursor].organObj.SetActive(false);
                _cursor--;
                ActivateObjectByIndex(_cursor);
            }
            else
            {
                organsList[_cursor].organObj.SetActive(false);
                _cursor = organsList.Count - 1;
                ActivateObjectByIndex(_cursor);
            }
        }

        public void OnNext()
        {
            NextObject();
        }

        public void OnPrevious()
        {
            PreviousObject();
        }
    }
}