using UnityEditor;
using UnityEngine;

namespace ShootEmUp
{
    public sealed class GameManager : MonoBehaviour, IGameListenerFinish
    {
        public void FinishGame()
        {
            Debug.Log("Game over!");
            EditorApplication.ExitPlaymode();
        }
    }
}