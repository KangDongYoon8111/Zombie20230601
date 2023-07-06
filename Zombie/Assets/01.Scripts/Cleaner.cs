using System;
using UnityEngine;

public class Cleaner : MonoBehaviour
{
    Action onClean;

    void Start()
    {
        onClean += CleaningRoomA;
        onClean += CleaningRoomB;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onClean();
            //CleaningRoomA();
            //CleaningRoomB();
        }
    }

    void CleaningRoomA()
    {
        Debug.Log("A�� û��");
    }

    void CleaningRoomB()
    {
        Debug.Log("B�� û��");
    }
}