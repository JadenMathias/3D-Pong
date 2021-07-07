using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public Rigidbody rbBall;
    public float velocity;

    // Start is called before the first frame update
    public void Start()
    {
        initializeMovement();
    }

    public void initializeMovement()
    {
        FindObjectOfType<freezeTime>().freeze();
        transform.position = new Vector3(0,10,0);
        rbBall.velocity = new Vector3(0,0,0);
        float xRand = Random.value < 0.5 ? -1.0f : 1.0f;
        float yRand = Random.value < 0.5 ? -1.0f : 1.0f;
        float zRand = Random.value < 0.5 ? -1.0f : 1.0f;

        rbBall.AddForce(xRand*velocity,yRand*velocity,zRand*velocity);
        rbBall.AddTorque(xRand*velocity,yRand*velocity,zRand*velocity);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Mathf.Floor(Mathf.Abs(transform.position.z)) == 0)
        {
            

            if (rbBall.velocity.z > 0)
            {
                rbBall.velocity = rbBall.velocity + new Vector3(0.005f,0.005f,0.005f);                
            }
            else
            {
                rbBall.velocity = rbBall.velocity + new Vector3(0.005f,0.005f,-0.005f);                
            }
            
        }

        if (Mathf.Abs(Vector3.Dot(rbBall.velocity,new Vector3(0,0,1))) < 3)
        {
           
           rbBall.velocity = Vector3.Scale(rbBall.velocity,new Vector3(1,1,2f));
        }
        //Debug.Log(Vector3.Dot(rbBall.velocity,new Vector3(0,0,1)));
    
    }
    
    
}
