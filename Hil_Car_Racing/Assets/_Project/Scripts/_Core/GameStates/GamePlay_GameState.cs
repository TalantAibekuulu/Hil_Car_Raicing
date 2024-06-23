using Services;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;
namespace Game.Core
{
    public class GamePlay_GameState : GameStateBase
    {
        [Inject] private AudioService audioService;
        [Inject] private UIFactory uiFactory;
        
        public override void Enter()
        {
            InjectServices.Inject(this );

            SceneManager.LoadSceneAsync("GamePlay").completed += (_) =>
            {
                GamePlay_UI gamePlay_UI_Copy =uiFactory.GetUI<GamePlay_UI>() as GamePlay_UI;
                gamePlay_UI_Copy.ExitButton.onClick.AddListener(GoToMainMenu);
                audioService.PlayuAudio("Music");
            };

        }

        private void GoToMainMenu()
        {
            gameStateChanger.Change(new MainMenu_GameState());
        }
    }


}
