using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ShootEmUp
{
    public class HUDController: MonoBehaviour, IGameListenerUpdate, IGameListenerFinish, IGameListenerAwake, IGameListenerStart
    {
        [SerializeField] private Button _startButton;
        [SerializeField] private Button _finishButton;
        [SerializeField] private Button _pauseButton;
        [SerializeField] private GameCycle _gameCycle;
        [SerializeField] private TMP_Text _timerText;
        [SerializeField] private CountdownTimerController _countdownTimerController;

        public void TickGame(float deltaTime)
        {
            _timerText.text = _countdownTimerController.TimerDisplay();
        }

        public void FinishGame()
        {
            _startButton.onClick.RemoveAllListeners();
            _finishButton.onClick.RemoveAllListeners();
            _pauseButton.onClick.RemoveAllListeners();
        }
        public void GameAwake()
        {
            _startButton.onClick.AddListener(_gameCycle.StartGame);
        }

        public void StartGame()
        {
            _finishButton.onClick.AddListener(_gameCycle.FinishGame);
            _pauseButton.onClick.AddListener(_gameCycle.PauseGame);
        }
    }
}