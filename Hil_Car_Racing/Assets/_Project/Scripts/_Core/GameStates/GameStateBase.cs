using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game.Core
    {
    public class GameStateBase 
    {
        public GameStateChanger gameStateChanger;

        public virtual void Enter()
        { 
        
        }
        public virtual void Exit() 
        {
        
        }
        public virtual void Update() 
        {
        
        }
    }

}
