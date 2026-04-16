using TMPro;
using UnityEngine;

public class HeroDescriptionView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _descriptionText;

    public void SetData(string description)
    {
        _descriptionText.text = description;
    }
}