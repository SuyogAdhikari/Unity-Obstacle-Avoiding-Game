using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody rb;
    public float force;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w"))
        rb.AddForce(-500 * Time.deltaTime, 0, 0);

        if(Input.GetKey("a"))
        rb.AddForce( 0, 0,-force * Time.deltaTime);

        if(Input.GetKey("s"))
        rb.AddForce(force * Time.deltaTime, 0, 0);

        if(Input.GetKey("d"))
        rb.AddForce( 0, 0,force * Time.deltaTime);

        if(rb.position.y < -94)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
