using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;
    public int score = 0;
    public int highscore = 0;

    void Start()
    {
        scoreText.text="Score: " + score.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "PlayerWall")
        {
            if (highscore < score)
            {
                highscore=score;
                highscoreText.text = "Highscore: " + highscore.ToString();
            }
            score = 0;
            UpdateScore();
            FindObjectOfType<ballMovement>().initializeMovement();
            FindObjectOfType<stripMovement>().resetPosition();
            
        }
        if(collision.collider.name == "Player1")
        {
            score ++ ;
            UpdateScore();

        }

    }

    void GodMode()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score++;
            UpdateScore();
        }
    }
    


    void UpdateScore()
    {
         scoreText.text ="Score: " + score.ToString();   
    }
}
