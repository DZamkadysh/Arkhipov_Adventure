using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{

    private bool isPlayerNear;
    private SphereCollider collider;

    [SerializeField] GameObject wallDown;

    private void Awake()
    {

        collider = GetComponent<SphereCollider>();
    }


    void Update()
    {
        if ((Input.GetButtonDown("Jump")) && (isPlayerNear == true))
        {

            Svitch();
            RotateLever();
            isPlayerNear = false;
            collider.enabled = false;
        }
    }


    private void OnTriggerEnter(Collider PlayerNear)
    {
        if (PlayerNear.tag == "Player")
        {
            isPlayerNear = true;
        }
    }

    void Svitch()
    {
        if (wallDown.active  == true)
        {
            wallDown.SetActive(false);
        }
        
        else
        {
            wallDown.SetActive(true);

        }
    }


    void RotateLever()
    {
        transform.Rotate(0.0f, 90.0f, 0.0f);
    }
    
}
