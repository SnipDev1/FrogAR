using TMPro;
using UnityEngine;

namespace TargetAr
{
    public class ObjectController : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textMeshProUGUI;

        public void SetText(string text)
        {
            textMeshProUGUI.text = text;
        }
    }
}
