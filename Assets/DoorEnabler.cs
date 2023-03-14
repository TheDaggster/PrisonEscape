using System.Collections;
using System.Collections.Generic;using Unity.VisualScripting;
using UnityEngine;

public class DoorEnabler : MonoBehaviour
{
  [SerializeField] private Transform previousRoom;
  [SerializeField] private Transform nextRoom;
  private CameraMovement cam;


  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.tag == "Player")
    {
      if (collision.transform.position.x < transform.position.x)
        cam.MoveToRoom(nextRoom);
      else
        cam.MoveToRoom(previousRoom);
    }
  }
  private void Awake()
  {
    cam = Camera.main.GetComponent<CameraMovement>();
  }
}
