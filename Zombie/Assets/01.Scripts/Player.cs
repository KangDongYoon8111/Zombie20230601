using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Action onDeath;

    //public GameData gameData;

    void Start()
    {
        //gameData = FindObjectOfType<GameData>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Die();
        }
    }

    public void Die()
    {
        onDeath();
    }
}
