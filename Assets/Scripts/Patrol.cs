using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class Patrol : MonoBehaviour
{

    [SerializeField] private Transform[] patrolPoints;

    private NavMeshAgent agent;

    private int m_CurentPointIndex;


    private void Awake()
    {

        agent = GetComponent<NavMeshAgent>();

    }

    void Start()
    {

        agent.SetDestination(patrolPoints[0].position);

    }

    void Update()
    {
        if (agent.remainingDistance < agent.stoppingDistance)
        {
            m_CurentPointIndex = (m_CurentPointIndex + 1) % patrolPoints.Length;
            agent.SetDestination(patrolPoints[m_CurentPointIndex].position);
        }
    }
}
