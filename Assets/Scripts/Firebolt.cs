using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firebolt : MonoBehaviour
{

    [SerializeField] private float _speed = 7f;

    [SerializeField] private Rigidbody rb;

    [SerializeField] private float damage = 1f;



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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Health health))
        {
            health.Hited(damage);
            Destroy(gameObject);

        }
    }

}
