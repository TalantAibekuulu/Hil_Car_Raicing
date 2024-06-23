using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game.Core
{
    public class GameStateChanger 
    {
        private GameStateBase _currentState;
        public void Change(GameStateBase gameState)
        {
            _currentState?.Exit();

        _currentState = gameState;
            _currentState?.Enter();
            _currentState.gameStateChanger =this;

        }

    }


}
