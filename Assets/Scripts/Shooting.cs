using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    [SerializeField] private Transform fbSpawn;

    [SerializeField] GameObject firebolt;

    private bool isPlayerNear;

    private float timeBtwShots;

    [SerializeField] private float startTimeBtwShots = 1.5f;

    private void Update()
    {
        if ((timeBtwShots <= 0) && (Input.GetButtonDown("Jump")) && (isPlayerNear == true))
        {

            Shoot();
            timeBtwShots = startTimeBtwShots;

        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }


    }

    private void OnTriggerEnter(Collider PlayerNear)
    {
        if (PlayerNear.tag == "Player")
        {
            isPlayerNear = true;
        }
    }

    private void OnTriggerExit(Collider PlayerNear)
    {
        if (PlayerNear.tag == "Player")
        {
            isPlayerNear = false;
        }
    }

    void Shoot()
    {
        Instantiate(firebolt, fbSpawn.position, fbSpawn.rotation);
    }

}
