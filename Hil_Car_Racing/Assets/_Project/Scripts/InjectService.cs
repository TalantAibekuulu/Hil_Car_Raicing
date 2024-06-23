using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
namespace  Game.Servivce
{
    public class InjectService : MonoBehaviour
    {
        public static void Inject(object injectObect)
        {
            ProjectContext.Instance.Container.Inject(injectObect);  
        }
    }


}

