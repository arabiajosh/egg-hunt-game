using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshTargetAllocator : MonoBehaviour
{
    public GameObject[] targets;
    public NavMeshAgent[] agents;

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < agents.Length; i++)
        {
            if(agents[i].remainingDistance < 1.5f)
            {
                giveTarget(agents[i]);
            }
        }
    }

    void giveTarget(NavMeshAgent agent)
    {
        int targetIndex = Random.Range(0, targets.Length - 1);
        GameObject target = targets[targetIndex];
        agent.SetDestination(target.transform.position);
    }
}
