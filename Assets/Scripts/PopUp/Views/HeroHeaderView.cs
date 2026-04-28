using PopUp;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroHeaderView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _nameText;
    [SerializeField] private Image _heroImage;
    [SerializeField] private TextMeshProUGUI _levelText;

    public void SetData(HeaderData data)
    {
        _nameText.text = data.Name;
        _heroImage.sprite = data.Image;
        _levelText.text = data.Level.ToString();
    }
}