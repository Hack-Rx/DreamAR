using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerWaypointController : MonoBehaviour
{
    //public NavMeshAgent agent;
    public List<Transform> waypoints;
    private Transform targetWaypoint;
    private int targetWaypointIndex = 0;
    private float minDistance = 0.05f; //If the distance between the enemy and the waypoint is less than this, then it has reacehd the waypoint
    private int lastWaypointIndex;

    public float movementSpeed = 0.05f;
    private float rotationSpeed = 2.0f;

    // Use this for initialization
    void Start()
    {
        lastWaypointIndex = waypoints.Count - 1;
        targetWaypoint = waypoints[targetWaypointIndex];
        //Debug.Log(targetWaypointIndex);//Set the first target waypoint at the start so the enemy starts moving towards a waypoint
    }

    // Update is called once per frame
    void Update()
    {
       if (GlobalVariables.placed)
        {
            float movementStep = movementSpeed * Time.deltaTime;
            float rotationStep = rotationSpeed * Time.deltaTime;

            Vector3 directionToTarget = targetWaypoint.position - transform.position;
            Quaternion rotationToTarget = Quaternion.LookRotation(directionToTarget);

            transform.rotation = Quaternion.Slerp(transform.rotation, rotationToTarget, rotationStep);

            //Debug.DrawRay(transform.position, transform.forward * 50f, Color.green, 0f); //Draws a ray forward in the direction the enemy is facing
            //Debug.DrawRay(transform.position, directionToTarget, Color.red, 0f); //Draws a ray in the direction of the current target waypoint

            float distance = Vector3.Distance(transform.position, targetWaypoint.position);
            CheckDistanceToWaypoint(distance);
            //Debug.Log("Target Name:" + targetWaypoint.name.ToString() + "\tDistance:" + distance.ToString());
            transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, movementStep);
            //bool sucess = agent.SetDestination(targetWaypoint.position);
            //Debug.Log("Destination set correctly:" + sucess.ToString());
        }
    }
    void CheckDistanceToWaypoint(float currentDistance)
    {
        if (currentDistance <= minDistance)
        {
            targetWaypointIndex++;
            //StartCoroutine(UpdateTargetWaypoint());
            UpdateTargetWaypoint();
        }
    }
    void UpdateTargetWaypoint()
    {
        //yield return new WaitForSeconds(2);
        if (targetWaypointIndex > lastWaypointIndex)
        {
            targetWaypointIndex = 0;
        }
        targetWaypoint = waypoints[targetWaypointIndex];
    }
}
