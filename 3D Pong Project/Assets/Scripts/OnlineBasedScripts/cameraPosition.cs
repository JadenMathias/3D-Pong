using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPosition : MonoBehaviour
{
    public Camera mainCamera;
    void Start()
    {
        mainCamera = FindObjectOfType<Camera>();
        if (transform.position.z == -8.5f)
        mainCamera.transform.position = new Vector3(0,10,-28);
        else
        mainCamera.transform.position = new Vector3(0,10,28);

    }
}
