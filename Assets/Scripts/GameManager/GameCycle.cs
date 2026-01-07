using System;
using System.Collections.Generic;
using UnityEngine;

namespace ShootEmUp
{
    public class GameCycle: MonoBehaviour
    {
        private List<IGameListenerStart> _gameListenersStarts = new List<IGameListenerStart>();
        private List<IGameListenerFinish> _gameListenerFinishes = new List<IGameListenerFinish>();
        private List<IGameListener> _gameListeners = new List<IGameListener>();
        public Action OnGameStarted;
        public GameStatus currentGameStatus = GameStatus.stop;

        public enum GameStatus
        {
            start = 0,
            pause = 1,
            stop = 2
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

        public void AddListener(IGameListener gameListener)
        {
            _gameListeners.Add(gameListener);
        }
    }
}