namespace PopUp
{
    public class HeroStatsPresenter
    {
        private readonly HeroStatView _view;

        public HeroStatsPresenter(HeroStatView view)
        {
            _view = view;
        }

        public void SetStats(StatsData data)
        {
            _view.SetData(data);
        }
    }
}