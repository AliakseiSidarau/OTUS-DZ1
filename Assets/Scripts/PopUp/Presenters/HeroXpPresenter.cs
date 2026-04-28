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

        public void SetXpBar(XpData data)
        {
            _view.SetSprites(data);
        }
    }
}