using Assets.Codebase.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.CoreMechanic
{
    [RequireComponent(typeof(AudioSource))]
    public class ShowMusic : MonoBehaviour, IShow
    {
        [SerializeField]
        private AudioSource _music;

        private void Start()
        {
            ChangeUI.MusicChangedEvent += UpdateMusic;
        }

        public void Show(bool active)
        {
            if (active)
                _music.Play();
            else 
                _music.Stop();
        }

        private void UpdateMusic(AudioClip newMusic)
        {
            _music.clip = newMusic;
        }
    }
}