using UnityEngine;

public class Orc : Monstar
{
    public override void Attack()
    {
        base.Attack();
        Debug.Log("�츮�� �뿹�� ���� �ʴ´�!");
    }

    public void WarCry()
    {
        Debug.Log("�����Լ�!");
        // �����Լ� ó��...
        // 
        Monstar[] monstar = FindObjectsOfType<Monstar>();
        for(int i = 0; i < monstar.Length; i++)
        {
            monstar[i].damage += 10;
        }
    }

}
