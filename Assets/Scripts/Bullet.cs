using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Bullet : MonoBehaviour
{

    [SerializeField] private float bulletSpeed = 5f;

    [SerializeField] private float damage = 1f;


    private void Awake()
    {
        Destroy(gameObject, 2f);
    }

    private void FixedUpdate()
    {
        transform.position += transform.forward * bulletSpeed * Time.fixedDeltaTime;
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
