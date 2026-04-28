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
            SetHeader(model);
            SetDescription(model);
            SetStats(model);
            SetXp(model);
        }

        private void SetHeader(HeroViewModel model)
        {
            _header.SetData(model.Header);
        }

        private void SetDescription(HeroViewModel model)
        {
            _description.SetData(model.Description);
        }

        private void SetStats(HeroViewModel model)
        {
            _stats.SetData(model.Stats);
        }

        private void SetXp(HeroViewModel model)
        {
            if (_xpBar != null)
            {
                _xpBar.SetSprites(model.Xp);
            }
        }

        public void Show() => gameObject.SetActive(true);
        public void Hide() => gameObject.SetActive(false);
    }
}