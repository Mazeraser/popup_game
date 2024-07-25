using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Assets.Codebase.Mechanics.CoinReward;
using Zenject;

namespace Assets.Codebase.UI
{
    [RequireComponent(typeof(TMP_Text))]
    public class CoinCounterUI : MonoBehaviour
    {
        private ICoin _coinStorage;

        [Inject]
        private void Construct(ICoin coin)
        {
            _coinStorage = coin;
        }

        private void Update()
        {
            GetComponent<TMP_Text>().text = _coinStorage.Coins.ToString();
        }
    }
}
    
