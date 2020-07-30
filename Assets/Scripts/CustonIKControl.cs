using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustonIKControl : MonoBehaviour
{
    [SerializeField]
    private Transform uperarm_r;
    [SerializeField]
    private Transform lowerarm_r;
    [SerializeField]
    private Transform hand_r;

    [SerializeField]
    private Transform Target;
    private float uperarmSize;
    private float lowerarmSize;
    private void Start()
    {
        uperarmSize = Vector3.Distance(uperarm_r.position, lowerarm_r.position);
        lowerarmSize = Vector3.Distance(lowerarm_r.position, hand_r.position);
    }

    private void Update()
    {
        Vector3 dir = (Target.position - hand_r.position);

        hand_r.position = Target.position;
        
    }
}
