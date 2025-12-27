using UnityEngine;

namespace ShootEmUp
{
    [RequireComponent(typeof(Rigidbody2D))] 
    public sealed class Character : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private float _speed;
        private bool _isPlayer = true;
        
        public void MoveByRigidbodyVelocity(Vector2 vector)
        {
            var nextPosition = _rb.position + vector * _speed;
            _rb.MovePosition(nextPosition);
        }
    }   
}