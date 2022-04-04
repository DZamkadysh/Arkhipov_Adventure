using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    [SerializeField] private Transform[] enemySpawn;

    [SerializeField] GameObject enemy;


    void Start()
    {
        int[] enemy = new int[1];

        Spawn();

    }


    void Spawn()
    {
        for (int i = 0; i < enemySpawn.Length; i++)

            Instantiate(enemy, enemySpawn[i].position, enemySpawn[i].rotation);

    }

}
