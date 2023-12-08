using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class DuckScript : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Cache the speed that nav mesh agent wants to move at.
        float speed = navMeshAgent.desiredVelocity.magnitude;


        // Set the animator's Speed parameter based on the (possibly modified) speed that the nav mesh agent wants to move at.
        animator.SetFloat("speed", speed, 0.1f, Time.deltaTime);

    }
}
