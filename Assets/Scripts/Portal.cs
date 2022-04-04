using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    [SerializeField] private GameObject playerSpawnPoint;

    [SerializeField] private string ObjTag;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag.Equals(ObjTag))
        {
            collision.gameObject.transform.position = playerSpawnPoint.gameObject.transform.position;
        }

    }


}
