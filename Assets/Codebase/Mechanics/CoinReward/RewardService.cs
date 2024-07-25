using Assets.Codebase.Infrastructure;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Assets.Codebase.Mechanics.CoinReward
{
    public class RewardService : MonoBehaviour, IRewarder
    {
        private ICoin _coinStorage;

        [Tooltip("Determines how many coins will be given out per second of viewing time.")]
        [SerializeField]
        private int _rewardModifier;

        [Inject]
        private void Construct(ICoin coin) 
        {
            _coinStorage = coin;
        }

        private void Start()
        {
            CoreMechanicSource.ShowEndEvent += GetReward;
        }

        public void GetReward(float watchTime)
        {
            _coinStorage.AddCoins((int)watchTime*_rewardModifier);
        }
    }
}
    
