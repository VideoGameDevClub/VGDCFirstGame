using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTransfer : MonoBehaviour
{

    public Vector2 cameraChange;
    public Vector3 playerChange;
    private CameraMovement cam;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.GetComponent<CameraMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            cam.minPosition += cameraChange;
            cam.maxPosition += cameraChange;
            collision.transform.position += playerChange;
        }
    }
    //Change the “Camera Change” y or x position depending on how big the room is
    //Change the “Player Change” y to 2
    //In order to go back to the previous room, make the values that you typed above negative
   
    //The code works as it should be,however...
    //We need exact measurements of the room size in order for the transitions to look nicer
    //For now it looks wanky because I estimated a room size (8.5) just to see if it works
}
