using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Assets.Codebase.Infrastructure
{

    public class AdService : MonoBehaviour
    {
        [DllImport("__Internal")]
        private static extern void ShowAd();

        private void Awake()
        {
            ShowAd();
        }
    }
}