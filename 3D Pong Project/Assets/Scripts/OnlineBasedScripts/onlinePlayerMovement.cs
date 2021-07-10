using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class onlinePlayerMovement : MonoBehaviour
{
    PhotonView view;
    public Camera mainCamera;
    public LayerMask region;
    float zfactor = -8.5f;

    public Vector3 limitPoint(Vector3 v)
    {
        Vector3 newPosition;
        if(Mathf.Abs(v.x) > 9.5 || v.y > 19.5 || v.y < 0.5)
        {
            if (v.x > 9.5)
            {
                newPosition = new Vector3(9.5f,v.y,zfactor);
                return limitPoint(newPosition);
            }
            else if (v.x < -9.5)
            {
                newPosition = new Vector3(-9.5f,v.y,zfactor);
                return limitPoint(newPosition);
            }
            else if (v.y < 0.5)
            {
                newPosition = new Vector3(v.x,0.5f,zfactor);
                return limitPoint(newPosition);
            }
            else 
            {
                newPosition = new Vector3(v.x,19.5f,zfactor);
                return limitPoint(newPosition);
            }
        
        }
        return v;
    }
    void Start()
    {
        view = GetComponent<PhotonView>();
        mainCamera = FindObjectOfType<Camera>();
        
            
    }
    void FixedUpdate()
    {
        if(view.IsMine)
        {   
            if (mainCamera.transform.position.z > 0)
              zfactor = 8.5f;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit raycastHit,float.MaxValue,region))
                transform.position = limitPoint(Vector3.Scale(raycastHit.point,new Vector3(1,1,0)) + new Vector3(0,0,zfactor));    
        }
    }
}
