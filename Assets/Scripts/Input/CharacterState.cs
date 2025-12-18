using UnityEngine;

namespace ShootEmUp
{
    public class CharacterState: MonoBehaviour
    {
        [SerializeField] private GameManager gameManager;
        [SerializeField] private GameObject character;
        private void OnEnable()
        {
            character.GetComponent<CharacterHealth>().hpEmpty += OnCharacterDeath;
        }

        private void OnDisable()
        {
            character.GetComponent<CharacterHealth>().hpEmpty -= OnCharacterDeath;
        }

        private void OnCharacterDeath(GameObject _) => gameManager.FinishGame();
        
    }
}