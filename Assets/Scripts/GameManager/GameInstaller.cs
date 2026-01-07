using System;
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
            _gameCycle.AddStartListener(_playerMovementController);
            _gameCycle.AddStartListener(_levelBackground);
            _gameCycle.AddFinishListener(_playerMovementController);
        }
    }
}