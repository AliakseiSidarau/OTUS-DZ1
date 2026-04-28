using PopUp;
using TMPro;
using UnityEngine;

public class HeroDescriptionView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _descriptionText;

    public void SetData(DescriptionData data)
    {
        _descriptionText.text = data.Description;
    }
}