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
        // 총의 기준점 gunPivot을 3D 모델의 오른쪽 팔꿈치 위치로 이동
        //weaponPivot.position = animator.GetIKHintPosition(AvatarIKHint.RightElbow);

        weaponPivot.position = animator.GetIKPosition(AvatarIKGoal.LeftHand);
        weaponPivot.rotation = animator.GetIKRotation(AvatarIKGoal.LeftHand);

        // IK를 사용하여 왼손의 위치와 회전을 총의 왼쪽 손잡이에 맞춤
        //animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1.0f);
        //animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1.0f);

        //animator.SetIKPosition(AvatarIKGoal.LeftHand, leftHandMount.position);
        //animator.SetIKRotation(AvatarIKGoal.LeftHand, leftHandMount.rotation);

        //// IK를 사용하여 오른손의 위치와 회전을 총의 오른쪽 손잡이에 맞춤
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
