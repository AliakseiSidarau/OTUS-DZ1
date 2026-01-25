using UnityEngine;
using UnityEngine.UI;

namespace PopUp
{
    public sealed class HeroPopup: MonoBehaviour
    {
        [SerializeField] private HeroPopupView _viewPrefab;
        [SerializeField] private Hero _hero;
        [SerializeField] private Button _buttonToShowPopup;
        [SerializeField] private Button _closeButton;
        private HeroPopupPresenter _presenter;
        
        
        private void Awake()
        {
            _buttonToShowPopup.onClick.AddListener(Show);
            _closeButton.onClick.AddListener(Hide);
            _presenter = new HeroPopupPresenter(_viewPrefab, _hero);
            // CreatePopup();
        }

        // private void CreatePopup()
        // {
        //     var view = Instantiate(_viewPrefab, _viewContainer, Quaternion.identity);
        // }

        public void Show()
        {
            _viewPrefab.gameObject.SetActive(true);
            _presenter.Enabled();
        }

        public void Hide()
        {
            _viewPrefab.gameObject.SetActive(false);
            _presenter.Disabled();
        }
    }
}