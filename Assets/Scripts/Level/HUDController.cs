using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ShootEmUp
{
    public class HUDController: MonoBehaviour, IGameListenerFinish, IGameListenerAwake, IGameListenerStart
    {
        [SerializeField] private Button _startButton;
        [SerializeField] private Button _finishButton;
        [SerializeField] private Button _pauseButton;
        [SerializeField] private GameCycle _gameCycle;
        [SerializeField] private TMP_Text _timerText;
        // public void TickGame(float deltaTime)
        // {
        //     _timerText.text = _countdownTimerController.TimerDisplay();
        // }

        public void FinishGame()
        {
            _startButton.onClick.RemoveAllListeners();
            _finishButton.onClick.RemoveAllListeners();
            _pauseButton.onClick.RemoveAllListeners();
        }
        public void GameAwake()
        {
            _startButton.onClick.AddListener(() =>StartCoroutine(WaitAndStart()));
        }

        public void StartGame()
        {
            _finishButton.onClick.AddListener(_gameCycle.FinishGame);
            _pauseButton.onClick.AddListener(_gameCycle.PauseGame);
        }

        private IEnumerator WaitAndStart()
        {
            _startButton.gameObject.SetActive(false);
            for (int i = 3; i > 0; i--)
            {
                _timerText.text = i.ToString();
                yield return new WaitForSeconds(1);
            }
            _timerText.gameObject.SetActive(false);
            _gameCycle.StartGame();
        }
    }
}