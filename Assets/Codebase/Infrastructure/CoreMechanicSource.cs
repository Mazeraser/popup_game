using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Codebase.Mechanics.CoreMechanic;
using Assets.Codebase.Mechanics.Timer;
using System;
using Assets.Codebase.UI;
using Zenject;

namespace Assets.Codebase.Infrastructure
{
    [RequireComponent(typeof(ITimer))]
    public class CoreMechanicSource : MonoBehaviour
    {
        public static event Action<float> ShowEndEvent;

        private ShowImage _showImage;
        private ShowMusic _showMusic;

        private ITimer timer;

        [Inject]
        private void Construct(ShowImage showImage, ShowMusic showMusic)
        {
            _showImage = showImage;
            _showMusic = showMusic;
        }
        
        private void Start()
        {
            timer = GetComponent<ITimer>();

            ShowEndEvent += delegate { Debug.Log("Show is end"); };

            ShowUI.ActivateShow += StartShow;
            ShowUI.DeactivateShow += EndShow;
        }
        private void Update() 
        {
            if (timer.IsGone)
                EndShow();
        }

        [ContextMenu("start")]
        public void StartShow()
        {
            Debug.Log("Show is started");
            timer.SetActiveTimer = true;

            _showImage?.Show(true);
            _showMusic?.Show(true);
        }
        [ContextMenu("end")]
        public void EndShow()
        {
            ShowEndEvent?.Invoke(timer.MaxTime);
            timer.SetActiveTimer = false;

            _showImage?.Show(false);
            _showMusic?.Show(false);
        }
    }
}
    
