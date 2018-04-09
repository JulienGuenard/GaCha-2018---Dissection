using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.UIElements;
using UnityEditor;

public class CameraController : MonoBehaviour
{
  Transform hand;
  Vector3 moveBound;
  public float cameraSpeed;
  float speed;
  Vector3 handOrigin;
  Vector3 cameraOrigin;
  Vector3 offset;

  void Start()
  {
    hand = GameObject.Find("Hand").transform;
    handOrigin = hand.position;
    cameraOrigin = transform.position;
    offset = cameraOrigin - handOrigin;
  }

  void Update()
  {
    Move();
  }

  void Move()
  {
    float speedX = hand.position.x - transform.position.x + offset.x;
    float speedY = hand.position.y - transform.position.y + offset.y;
    float speedZ = hand.position.z - transform.position.z + offset.z;

    transform.position += new Vector3(speedX / 5, speedY / 5, speedZ / 5);
  }
}
