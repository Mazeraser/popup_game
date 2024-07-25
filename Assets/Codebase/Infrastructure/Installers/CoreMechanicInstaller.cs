using UnityEngine;
using Zenject;

namespace Assets.Codebase.Infrastructure.Installers
{
    public class CoreMechanicInstaller : MonoInstaller
    {
        [SerializeField]
        private CoreMechanicSource _coreMechanicPrefab;

        public override void InstallBindings()
        {
            var core = Container.InstantiatePrefabForComponent<CoreMechanicSource>(_coreMechanicPrefab);

            Container.BindInstance(core).AsSingle().NonLazy();
        }
    }
}
    