using UnityEngine;

public class AmmoPack : MonoBehaviour, IItem
{
    public int ammo = 30;

    public void Use(GameObject target)
    {
        // target�� ź���� �߰��ϴ� ó��
        Debug.Log("ź���� �����ߴ� : " + ammo);
    }

}
