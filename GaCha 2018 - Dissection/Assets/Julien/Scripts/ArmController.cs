using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.UIElements;

public class ArmController : MonoBehaviour
{
    Transform transformBound;
    public Vector3 moveBoundMin;
    public Vector3 moveBoundMax;
    public float cameraSpeed;
    public float maxSpeed;

    float speedX;
    float speedY;
    float speedZ;

    void Update()
    {
        Move();
    }

    void Move()
    {
        speedX = Input.GetAxis("Mouse X") * cameraSpeed;
        speedZ = Input.GetAxis("Mouse Y") * cameraSpeed;
        speedY = 0;

        if (speedX > maxSpeed)
            speedX = maxSpeed;

        if (speedX < -maxSpeed)
            speedX = -maxSpeed;

        if (speedZ > maxSpeed)
            speedZ = maxSpeed;

        if (speedZ < -maxSpeed)
            speedZ = -maxSpeed;

        if (Input.GetKey(KeyCode.LeftControl))
            speedY = -0.01f;
        else if (Input.GetKey(KeyCode.Space))
            speedY = 0.01f;

        transform.position += new Vector3(speedX, speedY, speedZ);

        CheckBounds();
    }

    void CheckBounds()
    {
        if (transform.position.x > moveBoundMax.x)
        {
            transform.position = new Vector3(moveBoundMax.x, transform.position.y, transform.position.z);
        }

        if (transform.position.x < moveBoundMin.x)
        {
            transform.position = new Vector3(moveBoundMin.x, transform.position.y, transform.position.z);
        }

        if (transform.position.y > moveBoundMax.y)
        {
            transform.position = new Vector3(transform.position.x, moveBoundMax.y, transform.position.z);
        }

        if (transform.position.y < moveBoundMin.y)
        {
            transform.position = new Vector3(transform.position.x, moveBoundMin.y, transform.position.z);
        }

        if (transform.position.z > moveBoundMax.z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, moveBoundMax.z);
        }

        if (transform.position.z < moveBoundMin.z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, moveBoundMin.z);
        }
    }
}
