using UnityEngine;

namespace ShootEmUp
{
    public sealed class GameManager : MonoBehaviour, IGameListenerFinish
    {
        public void FinishGame()
        {
            Debug.Log("Game over!");
            Application.Quit();
            // Time.timeScale = 0;
        }
    }
}