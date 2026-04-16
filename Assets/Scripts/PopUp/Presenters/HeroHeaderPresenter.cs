using UnityEngine;

namespace PopUp
{
    public class HeroHeaderPresenter
    {
        private readonly HeroHeaderView _view;

        public HeroHeaderPresenter(HeroHeaderView view)
        {
            _view = view;
        }

        public void SetHeader(string header, Sprite icon, string level)
        {
            _view.SetData(header, icon, level);
        }
    }
}