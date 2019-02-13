using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Display the name of collision object to player
        Debug.Log(collision.collider.tag);
        if (collision.collider.tag == "enemies")
        {
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<gameManager>().gameOver();
        }
    }
}
