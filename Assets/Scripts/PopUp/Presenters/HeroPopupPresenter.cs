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
               Header = new HeaderData(
                   _hero.name,
                   _hero.image,
                   _hero.level),
               
               Description = new DescriptionData(
                   _hero.description),
               
               Stats = new StatsData(
                   _hero.moveSpeed,
                   _hero.intelligence,
                   _hero.stamina,
                   _hero.damage, 
                   _hero.dexterity,
                   _hero.regeneration
                   ),
               
               Xp = new XpData(_hero.xpImage)
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