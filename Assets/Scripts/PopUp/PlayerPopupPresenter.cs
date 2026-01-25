using UnityEngine;

namespace PopUp
{
    public class PlayerPopupPresenter
    {
        private readonly PlayerModel _model;

        public PlayerPopupPresenter(PlayerModel model)
        {
            _model = model;
            _model.OnLevelUp.AddListener(OnLevelUp);
            _model.OnXpChanged.AddListener(UpdateXp);
        }
        
        private void OnLevelUp()
        {
            Debug.Log("Level Up! Новый уровень: " + _model.level);
        }

        public void OnLevelUpButton()
        {
            _model.level++;
            _model.OnLevelUp.Invoke();
        }

        private void UpdateXp(float newXp)
        {
            Debug.Log($"XP updated: {newXp}");
        }
    }
}