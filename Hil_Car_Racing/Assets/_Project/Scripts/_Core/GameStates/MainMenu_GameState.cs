
using Services;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Game.Core
{
    public class MainMenu_GameState : GameStateBase
    {
        [Inject] private UIFactory _uiFactory;
        [Inject] private AudioService _audioService;

        public override void Enter()
        {
            InjectServices.Inject(this);

            SceneManager.LoadSceneAsync("MainMenu").completed += (_) =>
            {
              MainMenu_UI mainMain_UICopy=_uiFactory.GetUI<MainMenu_UI>() as MainMenu_UI;
                mainMain_UICopy.playButton.onClick.AddListener(GoToGamePlay);
                _audioService.PlayuAudio("Music");
            };
        }

        private void GoToGamePlay()
        {
            gameStateChanger.Change(new GamePlay_GameState());
        }
    }


}

