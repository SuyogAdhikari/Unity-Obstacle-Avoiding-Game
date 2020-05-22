using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameComplete : MonoBehaviour
{
    public float delay = 1f;
   void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.name == "finish")
        {
            Invoke("newGame",delay);

        }     
    }

    void newGame()
    {
        SceneManager.LoadScene("GameComplete");
        
    }
}
