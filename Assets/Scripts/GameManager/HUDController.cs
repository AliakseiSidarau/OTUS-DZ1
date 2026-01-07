using System;
using UnityEngine;
using UnityEngine.UI;

namespace ShootEmUp
{
    public class HUDController: MonoBehaviour
    {
        [SerializeField] private Button _startButton;
        [SerializeField] private Button _finishButton;
        [SerializeField] private GameCycle _gameCycle;

        private void Awake()
        {
            _startButton.onClick.AddListener(_gameCycle.StartGame);
            _finishButton.onClick.AddListener(_gameCycle.FinishGame);
        }
    }
}