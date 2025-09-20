using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowPlayer : MonoBehaviour
{
    public Transform player;
    public float smoothTime = 0.3F;
    Vector3 velocity = Vector3.zero;

    public float distFromPlayer = 5f;

    void Start()
    {
        transform.position = player.position + new Vector3(0, 0, -distFromPlayer);
    }

    void LateUpdate()
    {

        Vector3 targetPosition = player.TransformPoint(new Vector3(0, 0, -distFromPlayer));

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
