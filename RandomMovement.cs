using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class RandomMovement : MonoBehaviour
{


    public float minSpeed = 3.5f;  // minimum range of speed to move
    public float maxSpeed = 5f;  // maximum range of speed to move

    public float minDistance = 1f;
    public float maxDistance = 10f;
    public float triggerDistance = 0.5f;

    NavMeshAgent agent;

    Vector3 waypoint;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = GetRandomSpeed();

        waypoint = transform.position; 
    }

    private void Update()
    {
        // Set a new waypoint if the monster gets close to the current one
        if(Vector3.Distance(transform.position, agent.pathEndPosition) < triggerDistance)
        {
            waypoint = GetRandomPosition() * Random.Range(minDistance, maxDistance);

            agent.SetDestination(waypoint);

            agent.speed = Random.Range(minSpeed, maxSpeed);
        }


        Debug.DrawLine(transform.position, agent.pathEndPosition, Color.yellow);
    }

    private Vector3 GetRandomPosition()
    {
        return new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
    }

    private float GetRandomSpeed()
    {
        return Random.Range(minSpeed, maxSpeed);
    }

}