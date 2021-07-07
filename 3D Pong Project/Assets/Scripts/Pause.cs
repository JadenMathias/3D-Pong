using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour



{
    public int pauseState = 0;

    public Material pauseMaterial;
    public Renderer background;

    void Start()
    {
        ResumeGame();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape pressed");
            if(pauseState == 0)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }   
        }
    }
    void PauseGame ()
    {
        pauseState = 1;
        background.enabled = true;
        pauseMaterial.EnableKeyword("_EMISSION");
        Time.timeScale = 0;
    }

    void ResumeGame ()
    {
        pauseState = 0;
        background.enabled = false;
        pauseMaterial.DisableKeyword("_EMISSION");
        Time.timeScale = 1;
    }
}
