using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
namespace Game
{
    public static class InjectServices 
    {
        public static void Inject(object obj) 
        {
        ProjectContext.Instance.Container.Inject(obj);

        }

      //  public static  T GetT(object obj)
       // {
       // return ProjectContext.Instance.Container.Resolve<T>()

      //  }
    }

}

