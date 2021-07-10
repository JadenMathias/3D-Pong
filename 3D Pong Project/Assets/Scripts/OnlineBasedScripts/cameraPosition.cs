using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class cameraPosition : MonoBehaviour
{
    public Camera mainCamera;
    PhotonView view;
    void Start()
    {
        view = GetComponent<PhotonView>();
        mainCamera = FindObjectOfType<Camera>(); 
        
        if(view.IsMine)
        {
            if (transform.position.z < 0)
            mainCamera.transform.position = new Vector3(0,10,-28);
            else
            {
                mainCamera.transform.position = new Vector3(0,10,28);
                mainCamera.transform.rotation = new Quaternion(0,180,0,1);
            }
        }
    }
}
