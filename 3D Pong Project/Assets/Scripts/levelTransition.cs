using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelTransition : MonoBehaviour
{
    public void gameLoader()
    {
        Invoke("joinGame",0.2f);
    }
    public void loadQuit()
    {
        Invoke("quitGame",0.2f);
    }
    public void joinGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
