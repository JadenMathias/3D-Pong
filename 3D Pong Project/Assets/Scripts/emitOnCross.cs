using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emitOnCross : MonoBehaviour
{
    public Material strip1;
    public Material strip2;
    public Material strip3;
    public Material strip4;

    public Transform ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.position.z < 10 && ball.position.z > 5)
        {
            strip1.EnableKeyword("_EMISSION");
        }
        else
        {
            strip1.DisableKeyword("_EMISSION");
        }

        if (ball.position.z < 5 && ball.position.z > 0)
        {
            strip2.EnableKeyword("_EMISSION");
        }
        else
        {
            strip2.DisableKeyword("_EMISSION");
        }
        if (ball.position.z < 0 && ball.position.z > -5)
        {
            strip3.EnableKeyword("_EMISSION");
        }
        else
        {
            strip3.DisableKeyword("_EMISSION");
        }
        if (ball.position.z < -5 && ball.position.z > -10)
        {
            strip4.EnableKeyword("_EMISSION");
        }
        else
        {
            strip4.DisableKeyword("_EMISSION");
        }
    }
}
