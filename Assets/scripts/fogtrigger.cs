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
    public float transitionDuration = 4.0f; // Duration of the fog transition
    private bool isFogEnabled = false; // Current fog state

    void Start()
    {
        // Initialize the fog to be disabled at the start
        RenderSettings.fog = false;
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
        // Toggle fog state
        isFogEnabled = !isFogEnabled;

        // Start the coroutine for smooth fog transition
        StartCoroutine(ChangeFogStateSmoothly(isFogEnabled));
    }

    IEnumerator ChangeFogStateSmoothly(bool enableFog)
    {
        float elapsedTime = 0;
        float startDensity = RenderSettings.fogDensity;
        float targetDensity = enableFog ? 0.35f : 0f; // Set target density based on fog enable state

        while (elapsedTime < transitionDuration)
        {
            // Calculate the current fog density based on the elapsed time
            float currentDensity = Mathf.Lerp(startDensity, targetDensity, elapsedTime / transitionDuration);

            // Apply the calculated density to the fog settings
            RenderSettings.fogDensity = currentDensity;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the final fog density is set correctly
        RenderSettings.fogDensity = targetDensity;

        // Enable or disable fog based on the final state
        RenderSettings.fog = enableFog;
    }
}
