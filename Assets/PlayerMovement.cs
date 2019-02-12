using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce=1000;
    public float movementForce = 500f;
    bool leftMove = false;
    bool rightMove = false;
    int netDir = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("runs on start!!");
        //rb.useGravity = false;
        //rb.AddForce(0,200,500);
    }

    // Update is called once per frame
    void Update()
    {
        //Player movement left
        leftMove = Input.GetKey("a");

        //Player movement right
        rightMove = Input.GetKey("d");
    }

    void FixedUpdate()
    {
        //adding a forwardForce
        netDir = (leftMove ? -1 : 0) + (rightMove?1:0);
        rb.AddForce(netDir*movementForce * Time.deltaTime, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
    }
}
