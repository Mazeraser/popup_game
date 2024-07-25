using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.UI
{
    public class ShowUI : MonoBehaviour
    {
        public static event Action ActivateShow;
        public static event Action DeactivateShow;
        
        public void Activate() => ActivateShow?.Invoke();
        public void Deactivate() => DeactivateShow?.Invoke();
    }
}