using UnityEngine;
using System;

namespace Assets.Codebase.UI
{
    public class PurchaseTimeUI : MonoBehaviour
    {
        public static event Action<int, float> SpentCoinEvent;

        [SerializeField]
        private int _neededCoins;
        [SerializeField]
        private float _addTime;

        public void AddTime()
        {
            SpentCoinEvent?.Invoke(_neededCoins, _addTime);
        }
    }
}
    
