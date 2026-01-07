using UnityEngine;

namespace ShootEmUp
{
    public class GameInstaller : MonoBehaviour
    {
        [SerializeField] private GameCycle _gameCycle;
        [SerializeField] private PlayerMovementController _playerMovementController;
        [SerializeField] private LevelBackground _levelBackground;

        private void Awake()
        {
            _gameCycle.AddListener(_playerMovementController);
            _gameCycle.AddListener(_levelBackground);
        }
    }
}