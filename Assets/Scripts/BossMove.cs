using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class BossMove : MonoBehaviour
{
    private bool playerIsNear;

    private NavMeshAgent agent;
    private barbMove player;

    [SerializeField] private Transform bossSpawnPoint;


    private void Awake()
    {
        
        agent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<barbMove>();
    }


    private void Update()
    {
        if (playerIsNear == true)
        {
            agent.SetDestination(player.transform.position);
        }
        else
        {
            agent.SetDestination(bossSpawnPoint.transform.position);

        }
    }


    private void OnTriggerEnter(Collider other)
    {   
        if (other.tag == "Player")
        {
            playerIsNear = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsNear = false;
        }
    }
}
