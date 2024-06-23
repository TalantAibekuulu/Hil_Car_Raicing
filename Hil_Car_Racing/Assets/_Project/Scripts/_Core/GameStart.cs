using Services;
using UnityEngine;
using Zenject;
namespace Game.Core
{
    public class GameStart : MonoBehaviour
    {

        private GameStateChanger _gameStateChanger =new();

        private void Start()
        {
            DontDestroyOnLoad(gameObject);
            _gameStateChanger.Change(new MainMenu_GameState());

        }


    }
}