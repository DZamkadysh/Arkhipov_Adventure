using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(FindTarget))]

public class LookTarget : MonoBehaviour
{

    [SerializeField] private float rotationSpeed = 2f;

    private Vector3 _direction;

    private FindTarget findTarget;

    private void Start()
    {
        findTarget = GetComponent<FindTarget>();
    }


    void FixedUpdate()
    {
        if (!findTarget.HaveTarget) { return; }

        var direction = findTarget.Target.position - transform.position;
        var step =  Vector3.RotateTowards(transform.forward, direction, rotationSpeed * Time.fixedDeltaTime, 0f);

        transform.rotation = Quaternion.LookRotation(step);
    }


}
