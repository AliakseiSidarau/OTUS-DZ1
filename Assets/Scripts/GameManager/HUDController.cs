using System;
using UnityEngine;
using UnityEngine.UI;

namespace ShootEmUp
{
    public class HUDController: MonoBehaviour
    {
        [SerializeField] private Button _startButton;
        [SerializeField] private GameCycle _gameCycle;
        private string _startText = "START";
        private string _pauseText = "PAUSE";

        private void Awake()
        {
            _startButton.onClick.AddListener(_gameCycle.StartGame);
        }
    }
}