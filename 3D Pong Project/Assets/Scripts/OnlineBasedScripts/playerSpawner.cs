using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class playerSpawner : MonoBehaviour
{
    
    public GameObject player1;
    //public GameObject player2;
    void Start()
    {
        if (PhotonNetwork.CountOfPlayers == 1)
            PhotonNetwork.Instantiate(player1.name,new Vector3(0,10,-8.5f),Quaternion.identity);
        else if (PhotonNetwork.CountOfPlayers == 2)
            PhotonNetwork.Instantiate(player1.name,new Vector3(0,10,8.5f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
