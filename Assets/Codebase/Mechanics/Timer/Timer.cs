using UnityEngine;
using UnityEngine.UI;
using Assets.Codebase.UI;
using Assets.Codebase.Mechanics.PurchaseTime;

namespace Assets.Codebase.Mechanics.Timer
{
    public class Timer : MonoBehaviour, ITimer
    {
        [SerializeField]
        private float _startTime;

        [SerializeField]
        private float _maxTime;
        private float _timer;

        private bool _running;

        private void Start()
        {
            Store.SecondsPurchasedEvents += RaiseTime;
            ChangeUI.ImageChangedEvent += RewindTimer;
            
            _maxTime = _startTime;

            SetActiveTimer = false;

            ResetTimer();
        }
        private void Update()
        {
            if (_running)
                _timer += Time.deltaTime;
            else
                _timer = 0;
        }

        public void RaiseTime(float time)
        {
            _maxTime += time;
        }
        public void ResetTimer()
        {
            _timer = 0;
        }
        public void RewindTimer(Sprite sprite)
        {
            _maxTime = _startTime;
        }
        public bool SetActiveTimer
        {
            set { _running = value; }
        }
        public bool IsGone
        {
            get { return _timer >= _maxTime; }
        }
        public float MaxTime
        {
            get { return _maxTime; }
        }
    }
}