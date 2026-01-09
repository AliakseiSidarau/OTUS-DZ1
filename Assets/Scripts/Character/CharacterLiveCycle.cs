using UnityEngine;

namespace ShootEmUp
{
    public class CharacterLiveCycle: MonoBehaviour, IGameListenerStart, IGameListenerFinish
    {
        [SerializeField] private GameManager _gameManager;
        [SerializeField] private GameObject _character;

        private void OnCharacterDeath(GameObject _) => _gameManager.FinishGame();

        public void StartGame()
        {
            _character.GetComponent<CharacterHealth>().hpEmpty += OnCharacterDeath;
        }

        public void FinishGame()
        {
            _character.GetComponent<CharacterHealth>().hpEmpty -= OnCharacterDeath;
        }
    }
}