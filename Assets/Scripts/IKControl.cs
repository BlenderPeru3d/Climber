using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKControl : MonoBehaviour
{
    protected Animator animator;

    [SerializeField]
    private bool ikActive;
    [SerializeField]
    private Transform TargetManoDerecha = null;
    [SerializeField]
    [Range(0,1)]
    private float PesoManoDerecha;
    [SerializeField]
    private Transform clavicula;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // private void LateUpdate()
    // {
    //     clavicula.LookAt(TargetManoDerecha, Vector3.down);
    // }

    private void OnAnimatorIK()
    {
        if (animator)
        {
            if (ikActive)
            {
                if (TargetManoDerecha != null)
                {
                    animator.SetIKPositionWeight(AvatarIKGoal.RightHand, PesoManoDerecha);
                    animator.SetIKPosition(AvatarIKGoal.RightHand, TargetManoDerecha.position);
                }
            }
        }
    }
}