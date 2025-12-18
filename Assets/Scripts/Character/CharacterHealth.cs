using System;
using UnityEngine;

namespace ShootEmUp
{
    public class CharacterHealth: MonoBehaviour, IHealth
    {
        public event Action<GameObject> hpEmpty;
        
        [SerializeField] private int hitPoints;
        
        public bool IsHitPointsExists() {
            return this.hitPoints > 0;
        }
        public void TakeDamage(int damage)
        {
            this.hitPoints -= damage;
            if (this.hitPoints <= 0)
            {
                this.hpEmpty?.Invoke(this.gameObject);
            }
        }
    }
    
}