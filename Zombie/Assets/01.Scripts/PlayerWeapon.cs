using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public enum WeaponType { Sword, Hand, Gun}

    public WeaponType weaponType { get; private set; }

    public Transform leftHandMount;
    public Transform rightHandMount;
    public Transform weaponPivot;

    private Animator animator;

    void Start()
    {
        weaponType = WeaponType.Sword;
        animator = this.GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        // ���� ������ gunPivot�� 3D ���� ������ �Ȳ�ġ ��ġ�� �̵�
        //weaponPivot.position = animator.GetIKHintPosition(AvatarIKHint.RightElbow);

        weaponPivot.position = animator.GetIKPosition(AvatarIKGoal.LeftHand);
        weaponPivot.rotation = animator.GetIKRotation(AvatarIKGoal.LeftHand);

        // IK�� ����Ͽ� �޼��� ��ġ�� ȸ���� ���� ���� �����̿� ����
        //animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1.0f);
        //animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1.0f);

        //animator.SetIKPosition(AvatarIKGoal.LeftHand, leftHandMount.position);
        //animator.SetIKRotation(AvatarIKGoal.LeftHand, leftHandMount.rotation);

        //// IK�� ����Ͽ� �������� ��ġ�� ȸ���� ���� ������ �����̿� ����
        //animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1.0f);
        //animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1.0f);

        //animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandMount.position);
        //animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandMount.rotation);

        //switch (weaponType)
        //{
        //    case WeaponType.Sword:
        //        weaponPivot.position = animator.GetIKHintPosition(AvatarIKHint.RightElbow);

        //        animator.SetIKPositionWeight(AvatarIKGoal.LeftHand)
        //        break;

        //    case WeaponType.Gun:
        //        break;

        //    case WeaponType.Hand:
        //        break;

        //    default:
        //        break;
        //}
    }
}
