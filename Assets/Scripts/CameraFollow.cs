using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    // Update is called once per frame

    private void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothPositiion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position =  smoothPositiion;
    }
}
