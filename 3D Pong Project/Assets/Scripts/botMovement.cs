using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botMovement : MonoBehaviour
{
    public Transform ball;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,10,8);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Scale(ball.position, new Vector3(1,1,0)) + new Vector3(0,0,8);
    }
}