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

        public void SetHeader(HeaderData data)
        {
            _view.SetData(data);
        }
    }
}