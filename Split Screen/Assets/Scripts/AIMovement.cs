using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour
{
    NavMeshAgent navMesAgent;
    bool travelling;
    public float xMin, xMax, y, zMin, zMax;

    void Start()
    {
        navMesAgent = GetComponent<NavMeshAgent>();
        SetDestination();
    }

    void Update()
    {
        if (travelling && navMesAgent.remainingDistance <= 1f)
        {
            travelling = false;
            SetDestination();
        }
    }

    void SetDestination()
    {
        float x = Random.Range(xMin, xMax);
        float z = Random.Range(zMin, zMax);

        Vector3 targetPos = new Vector3(x, y, z);
        navMesAgent.SetDestination(targetPos);
        travelling = true;
    }
}
