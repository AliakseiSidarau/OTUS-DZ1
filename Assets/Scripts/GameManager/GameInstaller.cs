using UnityEngine;

namespace ShootEmUp
{
    public class GameInstaller : MonoBehaviour
    {
        [SerializeField] private GameCycle _gameCycle;
        [SerializeField] private PlayerMovementController _playerMovementController;
        [SerializeField] private LevelBackground _levelBackground;
        [SerializeField] private GameManager _gameManager;
        [SerializeField] private CharacterLiveCycle _characterLiveCycle;
        [SerializeField] private HUDController _hudController;
        [SerializeField] private EnemyManager _enemyManager;
        [SerializeField] private EnemyPool _enemyPool;

        private void Awake()
        {
            _gameCycle.AddListener(_playerMovementController);
            _gameCycle.AddListener(_levelBackground);
            _gameCycle.AddListener(_gameManager);
            _gameCycle.AddListener(_characterLiveCycle);
            _gameCycle.AddListener(_hudController);
            _gameCycle.AddListener(_enemyManager);
            _gameCycle.AddListener(_enemyPool);
        }
    }
}