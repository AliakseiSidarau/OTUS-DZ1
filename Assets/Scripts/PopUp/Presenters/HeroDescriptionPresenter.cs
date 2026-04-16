namespace PopUp
{
    public class HeroDescriptionPresenter
    {
        private readonly HeroDescriptionView _view;

        public HeroDescriptionPresenter(HeroDescriptionView view)
        {
            _view = view;
        }

        public void SetDescription(string description)
        {
            _view.SetData(description);
        }
    }
}