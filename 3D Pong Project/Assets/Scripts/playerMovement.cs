using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Camera mainCamera;
    public LayerMask region;

    public Vector3 limitPoint(Vector3 v)
    {
        Vector3 newPosition;
        if(Mathf.Abs(v.x) > 9.5 || v.y > 19.5 || v.y < 0.5)
        {
            if (v.x > 9.5)
            {
                newPosition = new Vector3(9.5f,v.y,-8.5f);
                return limitPoint(newPosition);
            }
            else if (v.x < -9.5)
            {
                newPosition = new Vector3(-9.5f,v.y,-8.5f);
                return limitPoint(newPosition);
            }
            else if (v.y < 0.5)
            {
                newPosition = new Vector3(v.x,0.5f,-8.5f);
                return limitPoint(newPosition);
            }
            else 
            {
                newPosition = new Vector3(v.x,19.5f,-8.5f);
                return limitPoint(newPosition);
            }
        
        }
        
        return v;
    }
    void Start()
    {
    }
    void FixedUpdate()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit,float.MaxValue,region))
        {
            transform.position = limitPoint(Vector3.Scale(raycastHit.point,new Vector3(1,1,0)) + new Vector3(0,0,-8.5f));
        }
    }
}
