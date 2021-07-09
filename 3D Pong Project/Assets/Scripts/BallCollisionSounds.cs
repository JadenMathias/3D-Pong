using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionSounds : MonoBehaviour
{
    public bool devSounds = false;
    void OnCollisionEnter(Collision collision)
    {
        if (devSounds)
        {
            playdevSounds(collision);
        }
        else
        {
            playsounds(collision);
        }
    }

    public void toggleSounds()
    {
        if(devSounds)
        {
            devSounds = false;
        }
        else
        {
            devSounds = true;
        }
    }
    void playsounds(Collision collision)
    {
        if(collision.collider.name == "Player1" || collision.collider.name == "Bot") 
        {
            FindObjectOfType<AudioManager>().Play("playerhit");

        }

        if(collision.collider.name == "WallRight")
        {
            FindObjectOfType<AudioManager>().Play("playerhit");
        }

        if(collision.collider.name == "WallLeft")
        {
            FindObjectOfType<AudioManager>().Play("playerhit");
        }

        if(collision.collider.name == "Floor")
        {
            FindObjectOfType<AudioManager>().Play("playerhit");
            
        }

        if(collision.collider.name == "Ceiling")
        {
            FindObjectOfType<AudioManager>().Play("playerhit");
        }
    }

    void playdevSounds(Collision collision)
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
