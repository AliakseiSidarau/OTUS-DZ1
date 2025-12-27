using UnityEngine;
using UnityEngine.Serialization;

namespace ShootEmUp
{
    public class PlayerAttack: MonoBehaviour
    {
        [SerializeField] private GameObject character;
        [SerializeField] private Weapon _weapon;
        [SerializeField] private BulletSystem _bulletSystem;
        [SerializeField] private BulletConfig _bulletConfig;
        
        public void Attack()
        {
            OnFlyBullet();
        }
        
        private void OnFlyBullet()
        {
            _bulletSystem.FlyBulletByArgs(new BulletSystem.Args
            {
                isPlayer = true,
                physicsLayer = (int) this._bulletConfig.physicsLayer,
                color = _bulletConfig.color,
                damage = _bulletConfig.damage,
                position = _weapon.Position,
                velocity = _weapon.Rotation * Vector3.up * _bulletConfig.speed
            });
        }
    }
}