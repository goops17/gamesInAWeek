using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class center_circle_script : MonoBehaviour
{
    float rotationSpeed = 50f;
    int direction = 1;
    // Update is called once per frame
    void Update()
    {
        //rotation of circle
        transform.Rotate(new Vector3(0,0,direction*rotationSpeed*Time.deltaTime),Space.Self);
    }
}
