using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ButtonScaler : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    public float finalScale = 1.2f;
    public float ScaleDuration = .1f;

    private Vector3 _defaulScale;
    private Tween _currentTween;

    private void Awake()
    {
        _defaulScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter");
        //transform.localScale = Vector3.one * 1.2f;
        _currentTween = transform.DOScale(finalScale*_defaulScale, ScaleDuration);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Exit");
        _currentTween.Kill();
        transform.localScale = _defaulScale;
    }
}
