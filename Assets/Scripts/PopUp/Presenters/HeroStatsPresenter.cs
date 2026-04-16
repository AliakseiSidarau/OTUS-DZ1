namespace PopUp
{
    public class HeroStatsPresenter
    {
        private readonly HeroStatView _view;

        public HeroStatsPresenter(HeroStatView view)
        {
            _view = view;
        }

        public void SetStats(
            string moveSpeedValue,
            string staminaValue,
            string dexterityValue,
            string intelligenceValue,
            string damageValue,
            string regenerationValue)
        {
            _view.SetData(moveSpeedValue,
                staminaValue,
                dexterityValue,
                intelligenceValue,
                damageValue,
                regenerationValue);
        }
    }
}