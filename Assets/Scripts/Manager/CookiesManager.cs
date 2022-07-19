using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CookiesManager : MonoBehaviour
{
    public float clickCount;
    public TextMeshProUGUI textCount;

    private void Start()
    {
        clickCount = 0;
        textCount.text = clickCount.ToString();
    }

    public virtual void AddCountClick(int quantidade = 1)
    {
        clickCount += quantidade;
        textCount.text = clickCount.ToString();

    }
}
