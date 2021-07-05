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
        float xRand = Random.value < 0.5 ? -1.0f : 1.0f;
        float yRand = Random.value < 0.5 ? -1.0f : 1.0f;
        float zRand = Random.value < 0.5 ? -1.0f : 1.0f;

        rbBall.AddForce(xRand*velocity,yRand*velocity,zRand*velocity);
        rbBall.AddTorque(xRand*velocity,yRand*velocity,zRand*velocity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
