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
        Debug.Log("A规 没家");
    }

    void CleaningRoomB()
    {
        Debug.Log("B规 没家");
    }
}
