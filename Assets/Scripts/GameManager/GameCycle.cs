using System;
using System.Collections.Generic;
using UnityEngine;

namespace ShootEmUp
{
    public class GameCycle: MonoBehaviour
    {
        private List<IGameListener> _gameListeners = new List<IGameListener>();
        private List<IGameListenerUpdate> _gameListenersTick = new List<IGameListenerUpdate>();
        public Action OnGameStarted;
        public GameStatus currentGameStatus = GameStatus.stop;

        public enum GameStatus
        {
            start = 0,
            pause = 1,
            stop = 2
        }

        private void Update()
        {
            var deltaTime = Time.deltaTime;
        }

        public void StartGame()
        {
            if (currentGameStatus != GameStatus.start)
            {
                Debug.Log("Start Game!");
                foreach (var listener in _gameListeners)
                {
                    if (listener is IGameListenerStart listenerStart)
                    {
                        listenerStart.StartGame();
                    }
                }

                currentGameStatus = GameStatus.start;
                OnGameStarted?.Invoke();
            }
            Debug.Log("Game Already started!");
        }

        public void FinishGame()
        {
            Debug.Log("Finish Game!");
            foreach (var listener in _gameListeners)
            {
                if (listener is IGameListenerFinish listenerFinish)
                {
                    listenerFinish.FinishGame();
                }
            }

            currentGameStatus = GameStatus.stop;
            OnGameStarted?.Invoke();
        }

        public void PauseGame()
        {
            
        }

        public void AddListener(IGameListener gameListener)
        {
            _gameListeners.Add(gameListener);
            if (gameListener is IGameListenerUpdate gameListenerUpdate)
            {
                _gameListenersTick.Add(gameListenerUpdate);
            }
        }
    }
}