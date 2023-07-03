using UnityEngine;

public class Orc : Monstar
{
    public override void Attack()
    {
        base.Attack();
        Debug.Log("우리는 노예가 되지 않는다!");
    }

    public void WarCry()
    {
        Debug.Log("전투함성!");
        // 전투함성 처리...
        // 
        Monstar[] monstar = FindObjectsOfType<Monstar>();
        for(int i = 0; i < monstar.Length; i++)
        {
            monstar[i].damage += 10;
        }
    }

}
