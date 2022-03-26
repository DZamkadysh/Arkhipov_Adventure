using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forebolt : MonoBehaviour
{

    [SerializeField] private float _speed = 7f;

    [SerializeField] private Rigidbody rb;


    void Start()
    {
        rb.velocity = transform.right * _speed;
    }

    private void OnTriggerEnter(Collider hitInfo)
    {
        if (hitInfo.tag == "ShotStop") 
        {
            Destroy(gameObject);
        }


    }

}
