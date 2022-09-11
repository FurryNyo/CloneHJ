using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    public Vector3 Offset;
    public float PositionOffset;
    public float SmoothDamp;

    private Vector3 Velocity;

    private void FixedUpdate()
    {
        Vector3 TargetPosition = Player.position + Offset;

        if (Player.position.y < transform.position.y + PositionOffset)
            transform.position = Vector3.SmoothDamp(transform.position, TargetPosition, ref Velocity, SmoothDamp);
    }
}
