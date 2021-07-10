using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class onlineScoreUpdate : MonoBehaviour
{
    public Text score1Text;
    public Text score2Text;

    public int score1 = 0;
    public int score2 = 0;



    void Start()
    {
        score1Text.text=score1.ToString();
        score2Text.text=score2.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if(collision.collider.name == "Player2Wall" && PhotonNetwork.CurrentRoom.PlayerCount == 2)
        { 
            UpdateScore1(); 
        }
        if(collision.collider.name == "Player1Wall" && PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {     
            UpdateScore2();       
        }
        

    }


    void UpdateScore1()
    {
        score1 ++;
        score1Text.text = score1.ToString();
        FindObjectOfType<onlineballMovement>().initializeMovement();
        FindObjectOfType<stripMovement>().resetPosition();   
    }
    void UpdateScore2()
    {
        score2 ++ ;
        score2Text.text =score2.ToString();
        FindObjectOfType<onlineballMovement>().initializeMovement();
        FindObjectOfType<stripMovement>().resetPosition();   
    }

}
