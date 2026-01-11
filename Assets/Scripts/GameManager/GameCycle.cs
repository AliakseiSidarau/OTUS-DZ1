using System;
using System.Collections.Generic;
using UnityEngine;

namespace ShootEmUp
{
    public class GameCycle: MonoBehaviour
    {
        private List<IGameListener> _gameListeners = new List<IGameListener>();
        private List<IGameListenerUpdate> _gameListenersTick = new List<IGameListenerUpdate>();
        private List<IGameListenerFixedUpdate> _gameListenersFixedTick = new List<IGameListenerFixedUpdate>();
        public Action OnGameStarted;
        public GameStatus currentGameStatus = GameStatus.awake;

        public enum GameStatus
        {
            awake = 0,
            start = 1,
            pause = 2,
            finish = 3
        }

        private void Awake()
        {
            foreach (var listener in _gameListeners)
            {
                if (listener is IGameListenerAwake listenerAwake)
                {
                    listenerAwake.GameAwake();
                }
            }
        }

        private void Update()
        {
            var deltaTime = Time.deltaTime;
            foreach (var listener in _gameListenersTick)
            {
                listener.TickGame(deltaTime);
            }
        }

        private void FixedUpdate()
        {
            var fixedDeltaTime = Time.fixedDeltaTime;
            foreach (var listener in _gameListenersFixedTick)
            {
                listener.FixedTickGame(fixedDeltaTime);
            }
        }

        public void StartGame()
        {
            if (currentGameStatus == GameStatus.awake)
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
            Debug.Log("Game Already started or press Pause!");
        }
        
        public void PauseGame()
        {
            if (currentGameStatus == GameStatus.start)
            {
                Debug.Log("Pause game!");
                foreach (var listener in _gameListeners)
                {
                    if (listener is IGameListenerPause listenerPause)
                    {
                        listenerPause.PauseGame();
                    }
                }
                currentGameStatus = GameStatus.pause;
                OnGameStarted?.Invoke();
            }
            else if (currentGameStatus == GameStatus.pause)
            {
                Debug.Log("Resume game!");
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
            else
            {
                Debug.Log("This game was finished! Press START for new game!");
            }
        }

        public void FinishGame()
        {
            if (currentGameStatus != GameStatus.finish)
            {
                Debug.Log("Finish Game!");
                foreach (var listener in _gameListeners)
                {
                    if (listener is IGameListenerFinish listenerFinish)
                    {
                        listenerFinish.FinishGame();
                    }
                }

                currentGameStatus = GameStatus.finish;
                OnGameStarted?.Invoke();
            }
            else
            {
                Debug.Log("Game already finished!");
            }
        }

        public void AddListener(IGameListener gameListener)
        {
            _gameListeners.Add(gameListener);
            
            if (gameListener is IGameListenerUpdate gameListenerUpdate)
            {
                _gameListenersTick.Add(gameListenerUpdate);
            }
            else if (gameListener is IGameListenerFixedUpdate gameListenerFixedUpdate)
            {
                _gameListenersFixedTick.Add(gameListenerFixedUpdate);
            }
        }
    }
}