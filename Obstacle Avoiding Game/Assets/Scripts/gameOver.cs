using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public float delay = 1f;
   void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.name == "surface")
        {
            Invoke("newGame",delay);

        }     
    }

    void newGame()
    {
        SceneManager.LoadScene("scene 1");
    }
    
}
