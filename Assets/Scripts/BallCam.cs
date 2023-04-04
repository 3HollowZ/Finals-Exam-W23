using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCam : MonoBehaviour
{
    public Transform target; // Reference to the target Transform (the player)
    public float smoothSpeed = 0.125f; // Camera's smoothness
    public Vector3 offset; // Camera's offset from the target

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // Create a new Vector3 with the player's position plus the camera's offset
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Lerp the camera's position towards the desired position
        transform.position = smoothedPosition; // Set the camera's position to the smoothed position
        transform.LookAt(target); // Make the camera look at the target
    }
}
