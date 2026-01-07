using System;
using UnityEngine;

namespace ShootEmUp
{
    public sealed class LevelBackground : MonoBehaviour, IGameListenerStart, IGameListenerFinish
    {
        private float startPositionY;

        private float endPositionY;

        private float movingSpeedY;

        private float positionX;

        private float positionZ;

        private Transform myTransform;
        
        

        [SerializeField]
        private Params m_params;

        [SerializeField] private GameCycle _gameCycle;
        private bool _isGameStarted;

        private void Awake()
        {
            this.startPositionY = this.m_params.m_startPositionY;
            this.endPositionY = this.m_params.m_endPositionY;
            this.movingSpeedY = this.m_params.m_movingSpeedY;
            this.myTransform = this.transform;
            var position = this.myTransform.position;
            this.positionX = position.x;
            this.positionZ = position.z;
        }

        private void FixedUpdate()
        {
            if (_isGameStarted)
            {
                MoveBackground();
            }
        }

        [Serializable]
        public sealed class Params
        {
            [SerializeField]
            public float m_startPositionY;

            [SerializeField]
            public float m_endPositionY;

            [SerializeField]
            public float m_movingSpeedY;
        }

        public void StartGame()
        {
            _gameCycle.OnGameStarted += GameStatusChecker;
        }

        private void MoveBackground()
        {
            if (this.myTransform.position.y <= this.endPositionY)
            {
                this.myTransform.position = new Vector3(
                    this.positionX,
                    this.startPositionY,
                    this.positionZ
                );
            }

            this.myTransform.position -= new Vector3(
                this.positionX,
                this.movingSpeedY * Time.fixedDeltaTime,
                this.positionZ
            );
        }

        private void GameStatusChecker()
        {
            if (_gameCycle.currentGameStatus == GameCycle.GameStatus.start)
            {
                _isGameStarted = true;
                Debug.Log($"Game Started is {_isGameStarted}");
            }
            else if(_gameCycle.currentGameStatus == GameCycle.GameStatus.stop)
            {
                _isGameStarted = false;
            }
        }

        public void FinishGame()
        {
            _gameCycle.OnGameStarted -= GameStatusChecker;
            _isGameStarted = false;
        }
    }
}