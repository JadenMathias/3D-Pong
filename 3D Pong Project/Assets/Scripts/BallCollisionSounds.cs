using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionSounds : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Player1" || collision.collider.name == "Bot") 
        {
            FindObjectOfType<AudioManager>().Play("playerhit");

        }

        if(collision.collider.name == "WallRight")
        {
            FindObjectOfType<AudioManager>().Play("bap");
        }

        if(collision.collider.name == "WallLeft")
        {
            FindObjectOfType<AudioManager>().Play("wallhit");
        }

        if(collision.collider.name == "Floor")
        {
            FindObjectOfType<AudioManager>().Play("wallhit2");
            
        }

        if(collision.collider.name == "Ceiling")
        {
            FindObjectOfType<AudioManager>().Play("bom");
        }
    } 
}
