using System.Collections.Generic;
using UnityEngine;

namespace TargetAr
{
    public class ElementsController : MonoBehaviour
    {
        public GameObject elementPrefab;
        public GameObject verticalLayout;
        private List<GameObject> _listOfElements = new();
        public void AddElement(string value)
        {
            var objectController = CreateText();
            _listOfElements.Add(objectController);
            objectController.GetComponentInChildren<ObjectController>().SetText(value);
        }

        public void ResetList()
        {
            if (_listOfElements.Count == 0)
            {
                return;
            }
            foreach (var element in _listOfElements)
            {
                Destroy(element);
            }
            _listOfElements.Clear();
        }
        
        private GameObject CreateText()
        {
            return Instantiate(elementPrefab, verticalLayout.transform);
        }
    }
}
