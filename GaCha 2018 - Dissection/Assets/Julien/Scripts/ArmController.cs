using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.UIElements;
using UnityEditor;

public class ArmController : MonoBehaviour
{
  Transform transformBound;
  public Vector3 moveBoundMin;
  public Vector3 moveBoundMax;
  public float cameraSpeed;
  public float maxSpeed;

  float speedX;
  float speedZ;

  public GameObject HandPos;

  void Start()
  {
    HandPos = GameObject.Find("HandPos");
  }

  void Update()
  {
    Move();
  }

  void Move()
  {
    speedX = Input.GetAxis("Mouse X") * cameraSpeed;
    speedZ = Input.GetAxis("Mouse Y") * cameraSpeed;

    if (speedX > maxSpeed)
      speedX = maxSpeed;

    if (speedX < -maxSpeed)
      speedX = -maxSpeed;

    if (speedZ > maxSpeed)
      speedZ = maxSpeed;

    if (speedZ < -maxSpeed)
      speedZ = -maxSpeed;

    transform.position += new Vector3(speedX, 0, speedZ);
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
