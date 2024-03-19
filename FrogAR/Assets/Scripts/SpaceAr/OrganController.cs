using System;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceAr
{
    public class OrganController : MonoBehaviour
    {
        public FrogController.OrganCategory organPoint;
        public bool isActive;
        [SerializeField] private GameObject elementController;
        private ToggleController _toggleController;
        [Serializable]
        public class Organs
        {
            public string organName;
            public string organDescription;
            public Sprite organImage;
            public GameObject organGameObject;
            public bool isActive;
        }

        public List<Organs> organsList = new();

        private void Start()
        {
            isActive = true;
        }

        public void ActivateAllOrgans()
        {
            isActive = true;
            foreach (var organs in organsList)
            {
                organs.organGameObject.SetActive(true);
            }
        }

        public void DeactivateAllOrgans()
        {
            isActive = false;
            foreach (var organs in organsList)
            {
                
                organs.organGameObject.SetActive(false);
            }
        }
    }
}