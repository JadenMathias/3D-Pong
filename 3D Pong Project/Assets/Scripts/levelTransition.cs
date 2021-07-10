using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

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
    void joinGame()
    {
        SceneManager.LoadScene("Game");
    }
    void quitGame()
    {
        Application.Quit();
    }

    public void backtoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void loadMultiplayer()
    {
        SceneManager.LoadScene("Loading");
    }

    public void leaveMultiplayer()
    {
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene("Menu");
    }

}
