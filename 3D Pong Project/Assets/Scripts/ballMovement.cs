using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public Rigidbody rbBall;
    public float velocity;
    public int flag = 1;

    // Start is called before the first frame update
    public void Start()
    {
        initializeMovement();
    }

    public void initializeMovement()
    {
        float xRand = Random.value < 0.5 ? -1.0f : 1.0f;
        float yRand = Random.value < 0.5 ? -1.0f : 1.0f;
        float zRand = Random.value < 0.5 ? -1.0f : 1.0f;

        rbBall.AddForce(xRand*velocity,yRand*velocity,zRand*velocity);
        rbBall.AddTorque(xRand*velocity,yRand*velocity,zRand*velocity);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector3.Dot(transform.position, new Vector3(0,0,1))==0)
        {
            if (flag % 2 ==0)
            {
                rbBall.velocity = rbBall.velocity + new Vector3(0,0,0.001f);                
            }
            else
            {
                rbBall.velocity = rbBall.velocity + new Vector3(0,0,-0.001f);                
            }

            flag=flag+1;
            
        }

        if (Mathf.Abs(Vector3.Dot(rbBall.velocity,new Vector3(0,0,1))) < 2)
        {
           if(Mathf.Abs(Vector3.Dot(rbBall.velocity,new Vector3(0,0,1))) == 0)
           {
               if (flag % 2 ==0)
                {
                rbBall.velocity = rbBall.velocity + new Vector3(0,0,4);                }
                else
                {
                rbBall.velocity = rbBall.velocity + new Vector3(0,0,-4);
                }
           }
           //rbBall.velocity = rbBall.velocity + new Vector3(0,0,5); 
           rbBall.velocity = Vector3.Scale(rbBall.velocity,new Vector3(1,1,1.25f));
        }
        Debug.Log(Vector3.Dot(rbBall.velocity,new Vector3(0,0,1)));
    }
    
    
}
