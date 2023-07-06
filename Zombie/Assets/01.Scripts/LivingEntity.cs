using System;
using UnityEngine;

// ����ü�� ������ ���� ������Ʈ���� ���� ���븦 ����
// ü��, ����� �޾Ƶ��̱�, ��� ���, ��� �̺�Ʈ�� ����
public class LivingEntity : MonoBehaviour, IDamageable
{
    public float startingHealth = 100f; // ����ü��
    public float health { get; private set; } // ����ü��
    public bool dead { get; protected set; } // ��� ����
    public event Action onDeath; // ��� �� �ߵ��� �̺�Ʈ

    // ����ü�� Ȱ��ȭ�� �� ���¸� ����
    protected virtual void OnEnable()
    {
        // ������� ���� ���·� ����
        dead = false;
        // ü���� ���� ü������ �ʱ�ȭ
        health = startingHealth;
    }
    // ������� �Դ� ���
    public virtual void OnDamage(float damage, Vector3 hitPoint, Vector3 hitNormal)
    {
        // �������ŭ ü�� ����
        health -= damage;

        // ü���� 0 ���� && ���� ���� �ʾҴٸ� ��� ó�� ����
        if(health <= 0 && !dead)
        {
            Die();
        }
    }

    // ü���� ȸ���ϴ� ���
    public virtual void RestoreHealth(float newHealth)
    {
        if (dead)
        {
            // �̹� ����� ��� ü���� ȸ���� �� ����
            return;
        }

        // ü�� �߰�
        health += newHealth;
    }

    // ��� ó��
    public virtual void Die()
    {
        // onDeath �̺�Ʈ�� ��ϵ� �޼��尡 �ִٸ� ����
        if(onDeath != null)
        {
            onDeath();
        }

        // ��� ���¸� ������ ����
        dead = true;
    }
}