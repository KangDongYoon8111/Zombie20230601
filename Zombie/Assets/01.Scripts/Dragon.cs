using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Monstar
{
    public override void Attack()
    {
        base.Attack();
        Debug.Log("��� ���� ��Ÿ���� ���̴�!");
    }
    public void Fly()
    {
        Debug.Log("����");
    }

    void Start()
    {
        Orc orc = FindObjectOfType<Orc>();
        Monstar monstar = orc;
        monstar.Attack();
    }


}
