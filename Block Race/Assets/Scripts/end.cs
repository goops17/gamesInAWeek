using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<gameManager>().levelComplete();
    }
}
