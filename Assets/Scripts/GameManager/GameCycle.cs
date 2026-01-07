using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

namespace ShootEmUp
{
    public class GameCycle: MonoBehaviour
    {
        private List<IGameListenerStart> _gameListenersStarts = new List<IGameListenerStart>();
        private List<IGameListenerFinish> _gameListenerFinishes = new List<IGameListenerFinish>();
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

        public void FinishGame()
        {
            Debug.Log("Finish Game!");
            foreach (var listener in _gameListenerFinishes)
            {
                listener.FinishGame();
            }

            currentGameStatus = GameStatus.stop;
            OnGameStarted?.Invoke();
        }

        public void AddStartListener(IGameListenerStart gameListenerStart)
        {
            _gameListenersStarts.Add(gameListenerStart);
        }
        
        public void AddFinishListener(IGameListenerFinish gameListenerFinish)
        {
            _gameListenerFinishes.Add(gameListenerFinish);
        }
    }
}