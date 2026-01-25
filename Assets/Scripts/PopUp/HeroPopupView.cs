using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PopUp
{
    public sealed class HeroPopupView: MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _nameText;
        
        [SerializeField] private Image _heroImage;
        
        [SerializeField] private TextMeshProUGUI _levelTextCounter;
        [SerializeField] private TextMeshProUGUI _heroDescription;
        
        [SerializeField] private Image _xpBarFull;
        [SerializeField] private Image _xpBarNotFull;
        
        [SerializeField] private TextMeshProUGUI _moveSpeedText;
        [SerializeField] private TextMeshProUGUI _intelligenceText;
        [SerializeField] private TextMeshProUGUI _staminaText;
        [SerializeField] private TextMeshProUGUI _damageText;
        [SerializeField] private TextMeshProUGUI _dexterityText;
        [SerializeField] private TextMeshProUGUI _regenerationText;

        [SerializeField] public Button _levelUpButton;

        public void SetName(string nameText)
        {
            this._nameText.text = nameText;
        }

        public void SetDescription(string heroDescription)
        {
            this._heroDescription.text = heroDescription;
        }

        public void SetImage(Sprite image)
        {
            this._heroImage.sprite = image;
        }

        public void SetLevel(string level)
        {
            this._levelTextCounter.text = level;
        }

        public void SetSpecs(
            string moveSpeed,
            string intelligence,
            string stamina,
            string damage,
            string dexterity,
            string regeneration
        )
        {
            this._moveSpeedText.text = moveSpeed;
            this._intelligenceText.text = intelligence;
            this._staminaText.text = stamina;
            this._damageText.text = damage;
            this._dexterityText.text = dexterity;
            this._regenerationText.text = regeneration;
        }
        
        
        
    }
}