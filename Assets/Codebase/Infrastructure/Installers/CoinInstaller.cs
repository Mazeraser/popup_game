using UnityEngine;
using Assets.Codebase.Mechanics.CoinReward;
using Assets.Codebase.Mechanics.PurchaseTime;
using Zenject;

namespace Assets.Codebase.Infrastructure.Installers
{
    public class CoinInstaller : MonoInstaller
    {
        [SerializeField]
        private RewardService _rewardService;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<Coin>().FromNewComponentOnNewGameObject().AsSingle().NonLazy();
            Container.Bind<Store>().FromNewComponentOnNewGameObject().AsSingle().NonLazy();
            Container.
                BindInstance(Container.InstantiatePrefabForComponent<RewardService>(_rewardService)).
                AsSingle().NonLazy();
        }
    }
}
    