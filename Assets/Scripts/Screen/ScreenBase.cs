using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using DG.Tweening;
using UnityEngine.UI;


namespace Screens
{

    public enum ScreenType
    {
        Panel,
        Info_Panel,
        Shop
    }

    public class ScreenBase : MonoBehaviour
    {
        public ScreenType screenType;

        public List<Transform> listOfObjects;
        public List<Typper> listOPhrases;

        public bool startHided = false;
        public Image uiBackground;

        [Header("Animation")]
        public float delayBetweenAnimations = .05f;
        public float animaitonDuration = .3f;

        private void Start()
        {
            if (startHided)
            {
                HideObjects();
            }
        }

        [Button]
        public virtual void Show()
        {
            Debug.Log("Show");
            ShowObjects();
        }
        [Button]
        public virtual void Hide()
        {
            Debug.Log("Hide");
            HideObjects();
        }

        private void HideObjects()
        {
            listOfObjects.ForEach(i=>i.gameObject.SetActive(false));
            uiBackground.enabled = false;
        }
        private void ShowObjects()
        {
            for(int i =0; i<listOfObjects.Count;i++)
            {
                var obj = listOfObjects[i];
                
                obj.gameObject.SetActive(true);
                obj.DOScale(0, animaitonDuration).From().SetDelay(i*delayBetweenAnimations);
            }
            Invoke(nameof(StartType), delayBetweenAnimations * listOfObjects.Count);
            uiBackground.enabled = true;
        }

        private void StartType()
        {
            for (int i = 0; i < listOPhrases.Count; i++)
            {
                listOPhrases[i].StartType();
            }

        }

        private void ForceShowObjects()
        {
            listOfObjects.ForEach(i=>i.gameObject.SetActive(true));
        }
    }
}