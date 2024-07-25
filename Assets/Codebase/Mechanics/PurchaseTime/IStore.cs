using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.PurchaseTime
{
    public interface IStore
    {
        void PurchaseSeconds(int neededCoins, float addSeconds);
    }
}