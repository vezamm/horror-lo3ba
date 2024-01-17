using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogtrigger : MonoBehaviour
{
    // Start is called before the first frame update
    /* private void OnTriggerEnter(Collider other)
     {
         if (other.CompareTag("Player"))
         {
             RenderSettings.fog = true;
         }
     }
     private void OnTriggerExit(Collider other)
     {
         if (other.CompareTag("Player"))
         {
             RenderSettings .fog = false;
         }
     }*/
    public float transitionDuration = 4.0f; 
    private bool isFogEnabled = false; 

    void Start()
    {
        // Initialize the fog to be disabled at the start
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ToggleFog();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ToggleFog();
        }
    }





    void ToggleFog()
    {
        isFogEnabled = !isFogEnabled;

        StartCoroutine(ChangeFogStateSmoothly(isFogEnabled));
    }

    IEnumerator ChangeFogStateSmoothly(bool enableFog)
    {
        float elapsedTime = 0;
        float startDensity = RenderSettings.fogDensity;
        float targetDensity = enableFog ? 0.2f : 0f; 
        if(enableFog)RenderSettings.fog = enableFog;

        while (elapsedTime < transitionDuration)
        {
            float currentDensity = Mathf.Lerp(startDensity, targetDensity, elapsedTime / transitionDuration);
           
            RenderSettings.fogDensity = currentDensity;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        RenderSettings.fogDensity = targetDensity;

        RenderSettings.fog = enableFog;
    }
}
