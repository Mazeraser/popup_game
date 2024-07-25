using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Assets.Codebase.UI;

namespace Assets.Codebase.Mechanics.CoreMechanic
{
    [RequireComponent(typeof(CanvasGroup))]
    [RequireComponent(typeof(Image))]
    public class ShowImage : MonoBehaviour, IShow
    {
        [SerializeField]
        private float _fadeDuration;

        private void Start()
        {
            ChangeUI.ImageChangedEvent += UpdateImage;
        }

        public void Show(bool active)
        {
            if (active)
                GetComponent<CanvasGroup>().DOFade(1f, _fadeDuration);
            else
                GetComponent<CanvasGroup>().DOFade(0f, _fadeDuration);
        }

        private void UpdateImage(Sprite newImage)
        {
            GetComponent<Image>().sprite = newImage;
        }
    }
}