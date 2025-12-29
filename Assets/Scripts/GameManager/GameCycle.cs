using UnityEngine;
using Button = UnityEngine.UI.Button;

namespace ShootEmUp
{
    public class GameCycle: MonoBehaviour
    {
        [SerializeField] private PlayerMovementController _playerMovementController;
        [SerializeField] private Button _startButton;
        
        private string _startText = "START";
        private string _pauseText = "PAUSE";

        void Start()
        {
            _startButton.onClick.AddListener(StartGame);
        }
        private void StartGame()
        {
            _playerMovementController.StartGame();
        }
    }
}