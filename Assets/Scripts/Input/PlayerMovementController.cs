using System;
using UnityEngine;

namespace ShootEmUp
{
    public sealed class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private Character _character;
        [SerializeField] private KeyboardInput _input;

        private void OnEnable()
        {
            _input.OnPlayerDirectionChanged += OnInputChanged;
        }

        private void OnDisable()
        {
            _input.OnPlayerDirectionChanged -= OnInputChanged;
        }

        private void OnInputChanged(Vector2 direction)
        {
            _character.MoveByRigidbodyVelocity(new Vector2(direction.x, 0) * Time.fixedDeltaTime);
        }
    }
}