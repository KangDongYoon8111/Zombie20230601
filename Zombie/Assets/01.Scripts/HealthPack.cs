using UnityEngine;

public class HealthPack : MonoBehaviour, IItem
{
    public float health = 50f;

    public void Use(GameObject target)
    {
        // target�� ü���� ȸ���ϴ� ó��
        Debug.Log("ü���� ȸ���ߴ� : " + health);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
