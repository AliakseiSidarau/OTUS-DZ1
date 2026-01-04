using System;
using System.Collections.Generic;
using UnityEngine;

namespace ShootEmUp
{
    public class GameCycle: MonoBehaviour
    {
        private List<IGameListenerStart> _gameListenersStarts = new List<IGameListenerStart>();
        public Action OnGameStarted;
        public GameStatus currentGameStatus;

        public enum GameStatus
        {
            start = 0,
            pause = 1,
            stop = 2
        }

        void Awake()
        {
            currentGameStatus = GameStatus.pause;
        }
        public void StartGame()
        {
           Debug.Log("Start Game!");
           foreach (var listener in _gameListenersStarts)
           {
               listener.StartGame();
           }

           currentGameStatus = GameStatus.start;
           OnGameStarted?.Invoke();
        }

        public void AddStartListener(IGameListenerStart gameListenerStart)
        {
            _gameListenersStarts.Add(gameListenerStart);
        }
    }
}