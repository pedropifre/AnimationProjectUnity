using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Car))]
public class CarEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        Car myTarget = (Car)target;
        myTarget.carPrefab = (GameObject)EditorGUILayout.ObjectField(myTarget.carPrefab, typeof(GameObject), true);
        myTarget.speed = EditorGUILayout.IntField("Minha Velocidade", myTarget.speed);
        myTarget.gear = EditorGUILayout.IntField("Marcah pai, exquece", myTarget.gear);

        EditorGUILayout.LabelField("Velocidade máxima", myTarget.TotalSpeed.ToString());

        EditorGUILayout.HelpBox("meu helpbox",MessageType.Info);

        if (myTarget.TotalSpeed >= 200)
        {
            EditorGUILayout.HelpBox("Velo acima meu filho", MessageType.Error);
        }

        if (GUILayout.Button("Create Car"))
        {
            myTarget.CreateCar();
        }

        
    }
}
