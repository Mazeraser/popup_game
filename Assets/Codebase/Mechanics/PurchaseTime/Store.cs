using Assets.Codebase.Mechanics.CoinReward;
using Assets.Codebase.UI;
using UnityEngine;
using Zenject;
using System;

namespace Assets.Codebase.Mechanics.PurchaseTime
{
    public class Store : MonoBehaviour, IStore
    {
        public static event Action<float> SecondsPurchasedEvents;

        private ICoin _coinStorage;

        [Inject]
        private void Construct(ICoin coin)
        {
            _coinStorage = coin;
        }

        private void Start()
        {
            PurchaseTimeUI.SpentCoinEvent += PurchaseSeconds;
        }

        public void PurchaseSeconds(int neededCoins, float addSeconds)
        {
            if (_coinStorage.SpentCoins(neededCoins))
            {
                Debug.Log(_coinStorage.Coins);
                SecondsPurchasedEvents?.Invoke(addSeconds);
            }
        }
    }
}