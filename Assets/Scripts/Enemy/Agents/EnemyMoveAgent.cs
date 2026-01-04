using UnityEngine;

namespace ShootEmUp
{
    public sealed class EnemyMoveAgent : MonoBehaviour
    {
       
        public bool IsReached
        {
            get { return this.isReached; }
        }
        
        [SerializeField] private Rigidbody2D _enemyRB;
        [SerializeField] private float _enemySpeed;

        private Vector2 destination;

        private bool isReached;
        private bool _isGameStarted = false;

        public void SetDestination(Vector2 endPoint)
        {
            this.destination = endPoint;
            this.isReached = false;
        }
        
        void MoveByRigidbodyVelocity(Vector2 vector)
        {
            var nextPosition = _enemyRB.position + vector * _enemySpeed;
            _enemyRB.MovePosition(nextPosition);
        }

        private void FixedUpdate()
        {
            if (_isGameStarted)
            {
                if (this.isReached)
                {
                    return;
                }
            
                var vector = this.destination - (Vector2) this.transform.position;
                if (vector.magnitude <= 0.25f)
                {
                    this.isReached = true;
                    return;
                }

                var direction = vector.normalized * Time.fixedDeltaTime;
                MoveByRigidbodyVelocity(direction);
            }
        }
    }
}