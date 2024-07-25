using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.CoinReward
{
    public class Coin : MonoBehaviour,ICoin
    {
        [SerializeField]
        private int _coins;

        private void Start()
        {
            _coins = 0;
        }

        public void AddCoins(int coins)
        {
            _coins += coins;
        }
        public bool SpentCoins(int coins)
        {
            if(_coins >= coins)
            {
                _coins -= coins;
                return true;
            }
            return false;
        }
        public int Coins { get { return _coins; } }
    }
}
    
