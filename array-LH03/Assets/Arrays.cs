using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    // 4 Werte, für jedes Array

    string[] array1 = new string[4] { "eins", "zwei", "drei", "vier"};
    float[] array2 = new float[4] { 1f, 2f, 3f, 4f };
    int[] array3 = { 1,2,3,4};

    //1) Durchlaufen ausgeben der Werte
    //2) Länge des Arrays ausgeben als Debug
    //3) 2 Werte direkt ändern
    //4) Gameobjects Images anlegen, Tag vergeben, Zuweisen und Farbe ändern

    //30min Projekt + Arrays Aufgabe -> Issues reinschreiben! Github pushen! 


    void Start()
    {
        OutputValuesArrays();
        Debug.Log("length array 1: " + array1.Length);
        Debug.Log("length array 2: " + array2.Length);
        Debug.Log("length array 3: " + array3.Length);

        array2[2] = 2.6f;
        array1[3] = "fünf";

        OutputValuesArrays();

    }

    void OutputValuesArrays()
    {
        for (int i = 0; i < 4; i++)
        {
            Debug.Log("value array 1: " + array1[i]);
            Debug.Log("value array 2: " + array2[i]);
            Debug.Log("value array 3: " + array3[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
