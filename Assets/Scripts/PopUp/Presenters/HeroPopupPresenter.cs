using UnityEngine;

namespace PopUp
{
    public sealed class HeroPopupPresenter
    {
        private readonly HeroPopupView _view;
        private readonly Hero _hero;

        public HeroPopupPresenter(HeroPopupView view, Hero hero)
        {
            _view = view;
            _hero = hero;
        }

        public void Enable()
        {
            var model = new HeroViewModel
            {
                Name = _hero.name,
                Description = _hero.description,
                Image = _hero.image,
                Level = _hero.level,

                MoveSpeedValue = _hero.moveSpeed,
                IntelligenceValue = _hero.intelligence,
                StaminaValue = _hero.stamina,
                DamageValue = _hero.damage,
                DexterityValue = _hero.dexterety,
                RegenerationValue = _hero.regeneration,
            };

            _view.SetData(model);
            _view.Init(OnLevelUpClicked);
            _view.Show();
        }

        public void Disable()
        {
            _view.Hide();
        }

        private void OnLevelUpClicked()
        {
            Debug.Log("Level Up!");
        }
    }
}