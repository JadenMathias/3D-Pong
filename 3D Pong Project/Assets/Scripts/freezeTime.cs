using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freezeTime : MonoBehaviour
{
    public float duration;
    float pendingDuration = 0f;
    bool isFrozen = false;
    void Update()
    {
        if(pendingDuration>0 && !isFrozen)
        {
            StartCoroutine(DoFreeze());
        }
        
    }

    public void freeze()
    {
        pendingDuration = duration;
    }

    IEnumerator DoFreeze()
    {
        isFrozen = true;
        var orginal = Time.timeScale;
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(duration);
        Time.timeScale = orginal;
        pendingDuration = 0;
        isFrozen = false;
    }
}
