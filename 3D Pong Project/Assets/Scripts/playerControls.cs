using UnityEngine;

public class playerControls : MonoBehaviour
{
    public float forwardForce =1000f;
    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate ()
    {
        if ( Input.GetKey("w") )
        {
            rb.AddForce(0,forwardForce * Time.deltaTime,0 );

        }
        
        if ( Input.GetKey("s") )
        {
            rb.AddForce(0,-1* forwardForce * Time.deltaTime,0 );

        }

        if ( Input.GetKey("d") )
        {
            rb.AddForce(forwardForce * Time.deltaTime,0,0 );

        }

        if ( Input.GetKey("a") )
        {
            rb.AddForce(-1*forwardForce * Time.deltaTime,0,0 );

        }
    }
}
