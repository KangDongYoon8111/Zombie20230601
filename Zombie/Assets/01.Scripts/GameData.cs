using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    private void Start()
    {
        Player player = FindObjectOfType<Player>();
        player.onDeath += Save;
        player.onDeath();
    }

    public void Save()
    {
        Debug.Log("게임 저장...");
    }
}
