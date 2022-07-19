using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;
using TMPro;

public class ButtonScaler : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    public float finalScale = 1.2f;
    public float ScaleDuration = .1f;

    private Vector3 _defaulScale;
    private Tween _currentTween;
    public TextMeshProUGUI textoSair;
    public string texto;
    public float timeBetweenLetters = .1f;

    private void Awake()
    {
        _defaulScale = transform.localScale;
        
    }
     //dsad
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter");
        //transform.localScale = Vector3.one * 1.2f;
        _currentTween = transform.DOScale(finalScale*_defaulScale, ScaleDuration);
        if (texto != "") StartCoroutine(Type(texto));
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Exit");
        _currentTween.Kill();
        transform.localScale = _defaulScale;
        if (texto != "") textoSair.text = "";
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
