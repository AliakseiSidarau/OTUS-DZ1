using UnityEngine;

namespace PopUp
{
    public class PlayerPopupController: MonoBehaviour
    {
        [SerializeField] private PlayerPopupView _view;
        private PlayerModel _model;
        private PlayerPopupPresenter _presenter;

        void Start()
        {
            _model = new PlayerModel();
            _presenter = new PlayerPopupPresenter(_model);
            _view.Init(_presenter);
            _model.OnXpChanged.AddListener((xp) => _view.UpdateXp(xp));
        }
    }
}