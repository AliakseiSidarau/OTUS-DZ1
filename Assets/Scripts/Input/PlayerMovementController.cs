using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;


namespace ShootEmUp
{
    public sealed class PlayerMovementController : MonoBehaviour, IGameListenerStart, IGameListenerFinish, IGameListenerPause, IGameListenerUpdate
    {
        [SerializeField] private Character _character;
        [SerializeField] private KeyboardInput _input;
        private Vector2 _direction;

        public void StartGame()
        {
            _input.OnPlayerDirectionChanged += OnInputChanged;
            Debug.Log("Move controller - start!");
        }
        
        public void FinishGame()
        {
            _input.OnPlayerDirectionChanged -= OnInputChanged;
            Debug.Log("Move controller - finish!");
        }
        
        private void OnInputChanged(Vector2 direction)
        {
            _direction = new Vector2(direction.x, 0);
        }

        public void PauseGame()
        {
            throw new System.NotImplementedException();
        }

        public void TickGame(float deltaTime)
        {
            _direction *= deltaTime;
            _character.MoveByRigidbodyVelocity(_direction);
        }
    }
}