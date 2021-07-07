using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stripMovement : MonoBehaviour
{
    public Material[] materials;
    public Renderer[] renders;
    public Transform ball;
    public Rigidbody rbBall;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        //Makes the strip move with the ball
        transform.position = Vector3.Scale(transform.position,new Vector3(1,1,0)) + Vector3.Scale(new Vector3(0,0,1),ball.position);
        
        //changes the material of the strips based on which direction it moves
        if (rbBall.velocity.z>0)
        {
            renders[0].sharedMaterial=materials[0];
            renders[1].sharedMaterial=materials[0];
            renders[2].sharedMaterial=materials[0];
            renders[3].sharedMaterial=materials[0];

        }
        else if (rbBall.velocity.z<0)
        {
            renders[0].sharedMaterial=materials[1];
            renders[1].sharedMaterial=materials[1];
            renders[2].sharedMaterial=materials[1];
            renders[3].sharedMaterial=materials[1];
        }
    }
   
}
