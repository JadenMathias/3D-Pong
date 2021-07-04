using UnityEngine;

public class playerControls : MonoBehaviour
{
    public float movementForce =100f;
    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate ()
    {
        if ( Input.GetKey("w") )
        {
            rb.AddForce(0,movementForce * Time.deltaTime,0,ForceMode.VelocityChange );

        }
        
        if ( Input.GetKey("s") )
        {
            rb.AddForce(0,-1* movementForce * Time.deltaTime,0,ForceMode.VelocityChange );

        }

        if ( Input.GetKey("d") )
        {
            rb.AddForce(movementForce * Time.deltaTime,0,0,ForceMode.VelocityChange );

        }

        if ( Input.GetKey("a") )
        {
        
            rb.AddForce(-1*movementForce * Time.deltaTime,0,0,ForceMode.VelocityChange);

        }
    }
}
