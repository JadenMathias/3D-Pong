using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botMovement : MonoBehaviour
{
    public Transform ball;
    public Rigidbody rbBall;
    public float difficulty;
    void Start()
    {
        transform.position = new Vector3(0,10,8.5f);
    }

    void FixedUpdate()
    {
        //assigns a vector position of the ball with a fixed xy plane at z = 8.5
        Vector3 x = Vector3.Scale(ball.position,new Vector3(1,1,8.5f/ball.position.z));

        //makes the bot move toward the xy position of the ball
        if (rbBall.velocity.z>0)
        {
        transform.position = Vector3.MoveTowards(transform.position,x,difficulty);
        }
    }
}
