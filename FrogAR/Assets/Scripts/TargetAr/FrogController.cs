using System;
using System.Collections.Generic;
using UnityEngine;

namespace TargetAr
{
    public class FrogController : MonoBehaviour
    {
        public enum OrganCategory
        {
            Body,
            Organs,
            Bones,
            Nerves,
            Muscles
        }

        [SerializeField] private GameObject toggleElementPrefab;
        [SerializeField] private GameObject verticalLayout;
        [SerializeField] private List<OrganController> organControllers = new();
        [SerializeField] private List<ToggleController> toggleControllers;
        [SerializeField] private ElementsController elementsController;
        private int _amountOfActivatedOrgans = 0;

        private void Start()
        {
            CreateTogglesByOrganControllersLength();
            _amountOfActivatedOrgans = organControllers.Count;
            throw new NotImplementedException();
        }

        public void ActivateOrgansByCategory(OrganCategory organPoint)
        {
            foreach (var organController in organControllers)
            {
                if (organController.organPoint == organPoint)
                {
                    organController.ActivateAllOrgans();
                    _amountOfActivatedOrgans++;
                }
            }

            Debug.Log(_amountOfActivatedOrgans);
            FindActivatedGroup();
        }

        public void DeactivateOrgansByCategory(OrganCategory organPoint)
        {
            foreach (var organController in organControllers)
            {
                if (organController.organPoint == organPoint)
                {
                    organController.DeactivateAllOrgans();
                    _amountOfActivatedOrgans--;
                }
            }

            Debug.Log(_amountOfActivatedOrgans);
            FindActivatedGroup();
        }

        private void FindActivatedGroup()
        {
            if (_amountOfActivatedOrgans != 1)
            {
                elementsController.ResetList();
                return;
            }
            
            foreach (var organController in organControllers)
            {
                if (!organController.isActive) continue;
                foreach (var organs in organController.organsList)
                {
                    elementsController.AddElement(organs.organName);
                }
            }
        }

        private void CreateTogglesByOrganControllersLength()
        {
            foreach (var organController in organControllers)
            {
                var createdObject = CreateToggle().GetComponentInChildren<ToggleController>();
                createdObject.SetPointer(organController.organPoint);
                toggleControllers.Add(createdObject);
            }
        }

        private GameObject CreateToggle()
        {
            return Instantiate(toggleElementPrefab, verticalLayout.transform);
        }
    }
}