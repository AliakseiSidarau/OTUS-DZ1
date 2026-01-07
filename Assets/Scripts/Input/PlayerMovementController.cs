using UnityEngine;

namespace ShootEmUp
{
    public sealed class PlayerMovementController : MonoBehaviour, IGameListenerStart, IGameListenerFinish, IGameListenerPause
    {
        [SerializeField] private Character _character;
        [SerializeField] private KeyboardInput _input;

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
            _character.MoveByRigidbodyVelocity(new Vector2(direction.x, 0) * Time.fixedDeltaTime);
        }

        public void PauseGame()
        {
            throw new System.NotImplementedException();
        }
    }
}