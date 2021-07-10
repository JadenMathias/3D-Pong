using UnityEngine;
using Photon.Pun;

public class playerSpawner : MonoBehaviour
{
    
    public GameObject player1;
    public GameObject player2;
    void Start()
    {
        
        if (PhotonNetwork.CurrentRoom.PlayerCount == 1)
            PhotonNetwork.Instantiate(player1.name,new Vector3(0,10,-8.5f),Quaternion.identity);
        else
            PhotonNetwork.Instantiate(player2.name,new Vector3(0,10,8.5f), Quaternion.identity);
    }

}
