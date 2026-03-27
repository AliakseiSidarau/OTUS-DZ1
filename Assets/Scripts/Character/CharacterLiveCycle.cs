using UnityEngine;

namespace ShootEmUp
{
    public class CharacterLiveCycle: MonoBehaviour
    {
        [SerializeField] private GameManager _gameManager;
        [SerializeField] private GameObject _character;
        private void OnEnable()
        {
            _character.GetComponent<CharacterHealth>().hpEmpty += OnCharacterDeath;
        }

        private void OnDisable()
        {
            _character.GetComponent<CharacterHealth>().hpEmpty -= OnCharacterDeath;
        }

        private void OnCharacterDeath(GameObject _) => _gameManager.FinishGame();
        
    }
}