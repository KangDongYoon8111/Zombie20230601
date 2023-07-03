using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstar : MonoBehaviour
{
    public float damage = 100;

    public virtual void Attack()
    {
        Debug.Log("공격");
        // 공격 처리...
    }
}
