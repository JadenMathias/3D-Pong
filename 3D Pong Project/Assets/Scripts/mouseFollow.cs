using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseFollow : MonoBehaviour
{
    public Camera mainCamera;
    public LayerMask region;
    public Rigidbody player;
    void Start()
    {
        player.isKinematic = false;
    }
    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit,20,region))
        {
            transform.position = Vector3.Scale(raycastHit.point,new Vector3(1,1,0)) + new Vector3(0,0,-7);
        }
        
        
    }
}
