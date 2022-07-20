using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ProjectUtils
{
#if UNITY_EDITOR
    [UnityEditor.MenuItem("Pedro/Teste")]
    public static void Test()
    {
        Debug.Log("teste menu");
    }
    
    [UnityEditor.MenuItem("Pedro/Teste 2 %g")]
    public static void Test2()
    {
        Debug.Log("teste menu 2");
    }
#endif

    public static void Scale(this Transform t, float size = 1.2f)
    {
        t.localScale = Vector3.one * size;
    }

    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

}
