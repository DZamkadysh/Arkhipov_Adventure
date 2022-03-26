using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSht : MonoBehaviour
{

    [SerializeField] private Transform fbSpawn;

    [SerializeField] GameObject firebolt;

    private float timeBtwShots;

    [SerializeField] private float startTimeBtwShots = 3.5f;


    private void Update()
    {

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
        Instantiate(firebolt, fbSpawn.position, fbSpawn.rotation);
    }

}