using UnityEngine.UI;
using System;
using UnityEngine;

namespace PopUp
{
    public sealed class HeroPopupView : MonoBehaviour
    {
        [SerializeField] private HeroHeaderView _header;
        [SerializeField] private HeroDescriptionView _description;
        [SerializeField] private HeroXpBarView _xpBar;
        [SerializeField] private HeroStatView _stats;
        [SerializeField] private Button _levelUpButton;

        public void Init(Action onLevelUpClicked)
        {
            _levelUpButton.onClick.RemoveAllListeners();
            _levelUpButton.onClick.AddListener(() => onLevelUpClicked?.Invoke());
        }

        public void SetData(HeroViewModel model)
        {
            _header.SetData(model.Name, model.Image, model.Level);
            _description.SetData(model.Description);

            _stats.SetData(
                model.MoveSpeedValue,
                model.IntelligenceValue,
                model.StaminaValue,
                model.DamageValue,
                model.DexterityValue,
                model.RegenerationValue
            );
        }

        public void Show() => gameObject.SetActive(true);
        public void Hide() => gameObject.SetActive(false);
    }
}