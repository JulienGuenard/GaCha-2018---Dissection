using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.UIElements;
using UnityEditor;

public class ArmController : MonoBehaviour
{
  Transform transformBound;
  Vector3 moveBound;
  public float cameraSpeed;
  public float maxSpeed;

  void Update()
  {
    Move();
  }

  void Move()
  {
    float speedX = Input.GetAxis("Mouse X") * cameraSpeed;
    float speedZ = Input.GetAxis("Mouse Y") * cameraSpeed;

    if (speedX > maxSpeed)
      speedX = maxSpeed;

    if (speedX < -maxSpeed)
      speedX = -maxSpeed;

    if (speedZ > maxSpeed)
      speedZ = maxSpeed;

    if (speedZ < -maxSpeed)
      speedZ = -maxSpeed;

    transform.position += new Vector3(speedX, 0, speedZ);
  }
}
