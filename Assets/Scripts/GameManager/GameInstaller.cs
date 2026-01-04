using System;
using UnityEngine;

namespace ShootEmUp
{
    public class GameInstaller : MonoBehaviour
    {
        [SerializeField] private GameCycle _gameCycle;
        [SerializeField] private PlayerMovementController _playerMovementController;
        // [SerializeField] private LevelBackground _levelBackground;
        [SerializeField] private EnemyManager _enemyManager;

        private void Awake()
        {
            _gameCycle.AddStartListener(_playerMovementController);
            // _gameCycle.AddStartListener(_enemyManager);
        }
    }
}