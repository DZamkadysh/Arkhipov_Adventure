using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTarget : MonoBehaviour
{
    [SerializeField] private string ObjTag;

    private Transform target;

    public Transform Target => target;
    public bool HaveTarget => target != null;


    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag.Equals(ObjTag))
        {
            target = collision.transform;
        }

    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag.Equals(ObjTag))
        {
            target = null;
        }
    }

}
