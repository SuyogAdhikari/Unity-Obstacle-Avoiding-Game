using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   bool gameHasEnded = false;
   public float restartDelay = 2f;
   public void EndGame()
   {
       if(gameHasEnded == false)
       {
           gameHasEnded = true;
           SceneManager.LoadScene("thanks");
       }
    }
}
