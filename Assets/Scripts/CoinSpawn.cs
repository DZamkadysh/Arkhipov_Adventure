using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{

    [SerializeField] private Transform[] coinSpawn;

    [SerializeField] GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        int[] coinSpawn = new int[6];

        Spawn();
    }


    void Spawn()
    {
        for (int i = 0; i < coinSpawn.Length; i++)

            Instantiate(coin, coinSpawn[i].position, coinSpawn[i].rotation);
    }

}

