using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    bool gameEnded=false;
    public void gameOver()
    {
        if (!gameEnded)
        {
            //Logging game over message
            Debug.Log("Game Over!");
            gameEnded = true;
            Invoke("restart", 2f);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
