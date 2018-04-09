using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.UIElements;
using UnityEditor;

public class HandController : MonoBehaviour
{
  Transform transformBound;
  Vector3 moveBound;
  public float cameraSpeed;

  void Start()
  {
    Cursor.lockState = CursorLockMode.Locked;
    transformBound = GameObject.Find("MoveBound").transform;
    moveBound = transformBound.GetComponent<BoxCollider>().size;
  }

  void Update()
  {
    Move();
    MoveForward();


  }

  void Move()
  {
    Debug.Log(transform.position + " " + moveBound);

    float speedX = Input.GetAxis("Mouse X") * cameraSpeed;
    float speedY = Input.GetAxis("Mouse Y") * cameraSpeed;

    if (speedX > 2)
      speedX = 2;

    if (speedX < -2)
      speedX = -2;

    if (speedY > 2)
      speedY = 2;

    if (speedY < -2)
      speedY = -2;

    /*
    if (!(transform.position.x < (-moveBound.x / 2) + transformBound.position.x) && Input.GetAxis("Mouse X") < 0)
      transform.position += new Vector3(speedX, 0, 0);

    if (!(transform.position.x > moveBound.x / 2 + transformBound.position.x) && Input.GetAxis("Mouse X") > 0)
      transform.position += new Vector3(speedX, 0, 0);

    if (!(transform.position.y < -moveBound.y / 2 + transformBound.position.y) && Input.GetAxis("Mouse Y") < 0)
      transform.position += new Vector3(0, speedY, 0);*/

    // if (!(transform.position.y > moveBound.y / 2 + transformBound.position.y) && Input.GetAxis("Mouse Y") > 0)
    // transform.position += new Vector3(0, speedY, 0);

    transform.position += new Vector3(speedX, speedY, 0);
  }

  void MoveForward()
  {
//    if (!(transform.position.z < moveBound.z / 2 + transformBound.position.z) && Input.GetAxis("Vertical") < 0)
    transform.position += new Vector3(0, 0, Input.GetAxis("Vertical"));

//    if (!(transform.position.z > moveBound.z / 2 + transformBound.position.z) && Input.GetAxis("Vertical") > 0)
//      transform.position += new Vector3(0, 0, Input.GetAxis("Vertical"));
  }
}
