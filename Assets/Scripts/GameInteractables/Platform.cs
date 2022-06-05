using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using System;

public class Platform : NetworkBehaviour
{
    [SerializeField] Transform mesh;
    [SerializeField] List<Transform> waypoints;
    [SerializeField] int currentIndex = 0;
    [SerializeField] float distance = 0.01f;
    [SerializeField] float speed = 1f;

    private void Update()
    {
        MovePlatform();
        UpdateIndex();
    }

    private void UpdateIndex()
    {
        if (Vector3.Distance(mesh.transform.position, waypoints[currentIndex].position) <= distance)
        {
            mesh.transform.position = waypoints[currentIndex].position;
            currentIndex = ( currentIndex + 1 ) % waypoints.Count;
        }
    }

    private void MovePlatform()
    {
        mesh.transform.position = Vector3.MoveTowards(mesh.transform.position, waypoints[currentIndex].position, speed * Time.deltaTime);
    }
}
