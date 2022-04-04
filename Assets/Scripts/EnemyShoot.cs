using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(FindTarget))]

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawn;

    [SerializeField] private Bullet bulletPrefab;

    private float timeBtwShots;

    private FindTarget findTarget;

    [SerializeField] private float startTimeBtwShots = 2f;


    private void Start()
    {
        findTarget = GetComponent<FindTarget>();
    }

    private void Update()
    {
        if (!findTarget.HaveTarget) { return; }

        if (timeBtwShots <= 0)
        {

            Shoot();
            timeBtwShots = startTimeBtwShots;


        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

    }


    void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
    }

}
