using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        //Display the position of player
       //Debug.Log(player.position.z;
        //Displaying text
        scoreText.text = (player.position.z+29).ToString("0");
    }
}
