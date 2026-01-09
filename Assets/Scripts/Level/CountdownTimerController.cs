using System.Globalization;
using UnityEngine;

namespace ShootEmUp
{
    public class CountdownTimerController : MonoBehaviour, IGameListenerStart, IGameListenerUpdate
    {
        public float timerTime = 3f;
        private float _currentTime;


        public void StartGame()
        {
            _currentTime = timerTime;
        }

        public void TickGame(float deltaTime)
        {
            if (_currentTime > 0)
            {
                _currentTime -= deltaTime;
            }
            else
            {
                _currentTime = 0;
            }
        }

        public string TimerDisplay()
        {
            return _currentTime.ToString("F1");
        }
    }
}