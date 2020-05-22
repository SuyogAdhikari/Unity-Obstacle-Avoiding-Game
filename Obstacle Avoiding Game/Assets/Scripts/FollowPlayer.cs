using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 offset;
    public Transform player;
    public float speed;
   
    // Update is called once per frame
    
    
    void Update()
    {
        transform.position = player.position + offset;

        if(Input.GetKey("q"))
        {
            transform.Rotate(0,-speed* Time.deltaTime, 0);
        }
        if(Input.GetKey("e"))
        {
            transform.Rotate(0,speed* Time.deltaTime, 0);
        }
    }
      
    
}
