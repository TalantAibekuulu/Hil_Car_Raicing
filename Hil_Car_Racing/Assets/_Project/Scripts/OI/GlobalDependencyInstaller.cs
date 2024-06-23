using Services;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
namespace Game
{
    public class GlobalDependencyInstaller : MonoInstaller
    {
        [SerializeField] private UIFactory _uiFactory;
        [SerializeField] private AudioService _audioService;
        public override void InstallBindings()
        {
            Container.Bind<UIFactory>().FromInstance(_uiFactory);
            Container.Bind<AudioService>().FromInstance(_audioService);
        }

    }
}
