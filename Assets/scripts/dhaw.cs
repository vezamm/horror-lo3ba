using UnityEngine;

public class dhaw : MonoBehaviour
{
    public GameObject flashlight_ground, inticon, flashlight_player;

    private void OnTriggerStay(Collider other)
    {
        // Check if the other collider has the "MainCamera" tag
        if (other.CompareTag("MainCamera"))
        {
            // Check if inticon is not null before accessing it
            if (inticon != null)
            {
                inticon.SetActive(true);
            }

            // Check for the "E" key press
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Check if flashlight_ground and inticon are not null before accessing them
                if (flashlight_ground != null)
                {
                    flashlight_ground.SetActive(false);
                }

                // Check if inticon is not null before accessing it
                if (inticon != null)
                {
                    inticon.SetActive(false);
                }

                // Check if flashlight_player is not null before accessing it
                if (flashlight_player != null)
                {
                    flashlight_player.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the other collider has the "MainCamera" tag and inticon is not null
        if (other.CompareTag("MainCamera") && inticon != null)
        {
            inticon.SetActive(false);
        }
    }
}
