using System;
using UnityEngine;

namespace ShootEmUp
{
    public sealed class PlayerMovement : MonoBehaviour
    {
        public event Action<float> OnPlayerDirectionChanged;
        public event Action<bool> OnPlayerFirePressed;
        public float HorizontalDirection { get; private set; }

        [SerializeField]
        private Rigidbody2D _characterRB;

        [SerializeField] private float _speed;
        
        [SerializeField] private PlayerAttack _playerAttack;
        
        private void Update()
        {
            HandleKeyboard();
        }

        void HandleKeyboard()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _playerAttack._fireRequired = true;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                HorizontalDirection = -1;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                HorizontalDirection = 1;
            }
            else
            {
                HorizontalDirection = 0;
            }
        }

        void MovePlayer(float direction)
        {
            OnPlayerDirectionChanged?.Invoke(direction);
        }

        void AttackPressPlayer(bool press)
        {
            OnPlayerFirePressed?.Invoke(press);
        }
        
        void MoveByRigidbodyVelocity(Vector2 vector)
        {
            var nextPosition = _characterRB.position + vector * _speed;
            _characterRB.MovePosition(nextPosition);
        }
        
        private void FixedUpdate()
        {
            MoveByRigidbodyVelocity(new Vector2(HorizontalDirection, 0) * Time.fixedDeltaTime);
        }
    }
}