using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;
using TMPro;

public class ButtonCookieScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float finalScale = 1.2f;
    public float ScaleDuration = .1f;

    private Vector3 _defaultPositionUp;
    private Vector3 _defaultPositionDown;
    private Tween _currentTween;

    public float timeBetweenLetters = .1f;
    public GameObject c_up;
    public GameObject c_down;
    public TextMeshProUGUI textoSair;
    public string texto;

    private void Awake()
    {
        _defaultPositionUp = c_up.gameObject.transform.localPosition;
        _defaultPositionDown = c_down.gameObject.transform.localPosition;
        textoSair.text = "";
        //Debug.Log(_defaultPosition);
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log(_defaultPosition);
        //transform.localScale = Vector3.one * 1.2f;
        _currentTween = c_up.gameObject.transform.DOMoveY(-2.1f, ScaleDuration);
        _currentTween = c_down.gameObject.transform.DOMoveY(-3.5f, ScaleDuration);
        StartCoroutine(Type(texto));
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("Exit");
        _currentTween.Kill();
        c_up.gameObject.transform.localPosition = _defaultPositionUp;
        c_down.gameObject.transform.localPosition = _defaultPositionDown;
        textoSair.text = "";
    }


    IEnumerator Type(string s)
    {
        textoSair.text = "";
        foreach (char c in s.ToCharArray())
        {
            textoSair.text += c;
            yield return new WaitForSeconds(timeBetweenLetters);
        }

    }
}
