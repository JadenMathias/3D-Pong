using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onlineBallCollisionSounds : MonoBehaviour
{
    public bool devSounds = false;
    public onlineScoreUpdate s;
    void OnCollisionEnter(Collision collision)
    {
        if (devSounds) playdevSounds(collision);
        else playsounds(collision);
        if (s.score1 % 5==0 && s.score1% 10 != 0 && s.score1!=0)
            {
                if(devSounds)
                FindObjectOfType<AudioManager>().Play("sheesh");
            }

            if (s.score1%10 == 0 && s.score1!=0)
            {
                if(devSounds)
                FindObjectOfType<AudioManager>().Play("sheesh2");
            }
    }

    public void toggleSounds()
    {
        devSounds = devSounds ? false : true;
    }
    void playsounds(Collision collision)
    {

        if(collision.collider.name == "Player1" || collision.collider.name == "Bot" || collision.collider.tag == "surface") 
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
