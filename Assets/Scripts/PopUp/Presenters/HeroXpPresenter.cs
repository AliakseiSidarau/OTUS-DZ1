using UnityEngine;

namespace PopUp
{
    public class HeroXpPresenter
    {
        private readonly HeroXpBarView _view;

        public HeroXpPresenter(HeroXpBarView view)
        {
            _view = view;
        }

        public void SetXpBar(Sprite xp_image)
        {
            _view.SetSprites(xp_image);
        }
    }
}