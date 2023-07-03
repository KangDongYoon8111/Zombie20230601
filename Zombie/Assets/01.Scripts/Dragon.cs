using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Monstar
{
    public override void Attack()
    {
        base.Attack();
        Debug.Log("모든 것이 불타오를 것이다!");
    }
    public void Fly()
    {
        Debug.Log("날기");
    }

    void Start()
    {
        Orc orc = FindObjectOfType<Orc>();
        Monstar monstar = orc;
        monstar.Attack();
    }


}
