using UnityEngine;

namespace PopUp
{
    public sealed class HeroPopupPresenter
    {
        private readonly HeroPopupView _view;
        private readonly Hero _hero;

        public HeroPopupPresenter(HeroPopupView view, Hero hero)
        {
            _hero = hero;
            _view = view;
        }

        public void Enabled()
        {
            _view.SetName(_hero.name);
            _view.SetDescription(_hero.description);
            _view.SetImage(_hero.image);
            _view.SetLevel(_hero.level);
            _view.SetSpecs(
                _hero.moveSpeed,
                _hero.intelligence,
                _hero.stamina,
                _hero.damage,
                _hero.dexterety,
                _hero.regeneration);
            _view._levelUpButton.onClick.AddListener(OnLevelUped);
        }

        private void OnLevelUped()
        {
            Debug.Log("Level Up!");
        }

        public void Disabled()
        {
            _view._levelUpButton.onClick.RemoveAllListeners();
        }
    }
}