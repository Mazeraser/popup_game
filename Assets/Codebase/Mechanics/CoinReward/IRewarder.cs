using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.CoinReward
{
    public interface IRewarder
    {
        void GetReward(float watchTime);
    }
}
    
