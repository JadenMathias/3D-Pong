using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseManage : MonoBehaviour



{
    public int pauseState = 0;

    public Material pauseMaterial;
    public Renderer background;

    void Start()
    {
        Application.targetFrameRate = 60;
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
