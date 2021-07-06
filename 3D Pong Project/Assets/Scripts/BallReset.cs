using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    public Rigidbody rbBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "PlayerWall")
        {
            transform.position = new Vector3(0,10,0);
        }
        
    }
}
