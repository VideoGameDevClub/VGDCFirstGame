using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float Smoothing;

    //boundaries
    public Vector2 maxPosition;
    public Vector2 minPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (transform.position != target.position)
        {
            //the Camera follows the Player at the X & Y positions
            // but it keeps its own Z position
            Vector3 targetPosition = new Vector3(target.position.x, 
                                                 target.position.y, 
                                                 transform.position.z);

            //This following code is used to place the boundaries on the X and Y coordinates of the camera
            //Clamp (block) the camera from seeing beyond the X position
            targetPosition.x = Mathf.Clamp(targetPosition.x,
                                           minPosition.x,
                                           maxPosition.x);
            //Clamp (block) the camera from seeing beyond the Y position
            targetPosition.y = Mathf.Clamp(targetPosition.y,
                                            minPosition.y,
                                            maxPosition.y);

            transform.position = Vector3.Lerp(transform.position, targetPosition, Smoothing);
        }
    }
}

