using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PopUp
{
    public class PlayerPopupView: MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _nameText;
        [SerializeField] private TextMeshProUGUI _levelTextCounter;
        [SerializeField] private Image _xpBarFull;
        [SerializeField] private Image _xpBarNotFull;
        [SerializeField] private TextMeshProUGUI _moveSpeedText;
        [SerializeField] private TextMeshProUGUI _intelligenceText;
        [SerializeField] private TextMeshProUGUI _staminaText;
        [SerializeField] private TextMeshProUGUI _damageText;
        [SerializeField] private TextMeshProUGUI _dexterityText;
        [SerializeField] private TextMeshProUGUI _regenerationText;

        private PlayerPopupPresenter _presenter;

        public void Init(PlayerPopupPresenter presenter)
        {
            _presenter = presenter;
            UpdateUI();
        }

        public void UpdateName(string name) => _nameText.text = name;
        public void UpdateLevel(string level) => _levelTextCounter.text = $"{level}";

        public void UpdateXp(float arg0)
        {
            
        }

        private void UpdateUI()
        {
            
        }
    }
}