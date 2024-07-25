using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.CoinReward
{
    public interface ICoin
    {
        void AddCoins(int coins);
        bool SpentCoins(int coins);
        int Coins {  get; }
    }
}
    
