using Assets.Codebase.Mechanics.CoinReward;
using System;
using UnityEngine;
using Zenject;

namespace Assets.Codebase.UI
{
    public class ChangeUI : MonoBehaviour
    {
        public static event Action<Sprite> ImageChangedEvent;
        public static event Action<AudioClip> MusicChangedEvent;

        [SerializeField]
        private AudioClip _newMusic;
        [SerializeField]
        private Sprite _newSprite;

        [SerializeField]
        private int _changeCost;

        private ICoin _coinStorage;

        [Inject]
        private void Construct(ICoin coinStorage)
        {
            _coinStorage = coinStorage;
        }

        public void ChangeShow()
        {
            if (_coinStorage.SpentCoins(_changeCost))
            {
                ImageChangedEvent?.Invoke(_newSprite);
                MusicChangedEvent?.Invoke(_newMusic);
            }
        }
    }
}