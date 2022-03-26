using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    [SerializeField] private Transform fbSpawn;

    [SerializeField] GameObject firebolt;

    private bool isPlayerNear;

    private void Update()
    {

         if (Input.GetButtonDown("Jump") && (isPlayerNear == true))
         {
             Shoot();
             isPlayerNear = false;
            
         }

    }

    private void OnTriggerEnter(Collider PlayerNear)
    {
        if (PlayerNear.tag == "Player")
        {
            isPlayerNear = true;
        }
    }

    void Shoot()
    {
        Instantiate(firebolt, fbSpawn.position, fbSpawn.rotation);
    }

}
