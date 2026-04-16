using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroHeaderView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _nameText;
    [SerializeField] private Image _heroImage;
    [SerializeField] private TextMeshProUGUI _levelText;

    public void SetData(string name, Sprite image, string level)
    {
        _nameText.text = name;
        _heroImage.sprite = image;
        _levelText.text = level;
    }
}