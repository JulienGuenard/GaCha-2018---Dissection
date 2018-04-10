﻿using System.Collections;
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
    MoveForward();
  }

  void Move()
  {
    float speedX = Input.GetAxis("Mouse X") * cameraSpeed;
    float speedY = Input.GetAxis("Mouse Y") * cameraSpeed;

    if (speedX > maxSpeed)
      speedX = maxSpeed;

    if (speedX < -maxSpeed)
      speedX = -maxSpeed;

    if (speedY > maxSpeed)
      speedY = maxSpeed;

    if (speedY < -maxSpeed)
      speedY = -maxSpeed;

    transform.position += new Vector3(speedX, speedY, 0);
  }

  void MoveForward()
  {
    transform.position += new Vector3(0, 0, Input.GetAxis("Vertical"));
  }
}
