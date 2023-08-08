using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraMovement : MonoBehaviour
{
    public float speed;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.position, transform.up, 1 * speed*Time.deltaTime);
    }
}