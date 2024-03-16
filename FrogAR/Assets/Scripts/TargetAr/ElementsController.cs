using System.Collections.Generic;
using UnityEngine;

namespace TargetAr
{
    public class ElementsController : MonoBehaviour
    {
        [SerializeField] private GameObject elementPrefab;
        [SerializeField] private GameObject verticalLayout;
        private readonly List<GameObject> _listOfElements = new();
        public void AddElement(string value, OrganController.Organs organs)
        {
            var item = CreateText();
            
            _listOfElements.Add(item);
            var objectController = item.GetComponentInChildren<ObjectController>();
            objectController.SetText(value);
            objectController.SetList(organs);
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
