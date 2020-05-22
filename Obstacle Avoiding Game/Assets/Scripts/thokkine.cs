using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class thokkine : MonoBehaviour
{
  
    public PlayerMovement movement;
    // Update is called once per frame
    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }

        if(collisionInfo.collider.tag == "Finish")
        {
            SceneManager.LoadScene("GameComplete");
        }
       
    }
  
}
