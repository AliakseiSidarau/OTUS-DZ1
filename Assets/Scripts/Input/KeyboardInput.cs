using System;
using UnityEngine;
using UnityEngine.UI;

namespace ShootEmUp
{
    public class KeyboardInput: MonoBehaviour
    {
        [SerializeField] private PlayerAttack _playerAttack;
        
        public event Action<Vector2> OnPlayerDirectionChanged;
        public event Action<bool> OnPlayerFirePressed;
        public Vector2 Direction { get; private set; }
        
        void MovePlayer(Vector2 dir)
        {
            OnPlayerDirectionChanged?.Invoke(dir);
        }

        void AttackPressPlayer(bool press)
        {
            OnPlayerFirePressed?.Invoke(press);
        }
        
        void HandleKeyboard()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _playerAttack._fireRequired = true;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {     
                Direction = new Vector2(-1f, 0);
                MovePlayer(Direction);
                
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                Direction = new Vector2(1f, 0);
                MovePlayer(Direction);
            }
            else
            {
                Direction = new Vector2(0, 0);
                MovePlayer(Direction);
            }
        }
        
        private void Update()
        {
            HandleKeyboard();
        }
    }
}