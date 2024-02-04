using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject inticon, keye , sign1 , sign2;
    public bool keyfound=false;
    public GameObject keyf;


    private void OnTriggerStay(Collider other)
    {
        // Check if the other collider has the "MainCamera" tag
        if (other.CompareTag("MainCamera"))
        {
            sign1.SetActive(true);
            sign2.SetActive(true);

            // Check if inticon is not null before accessing it
            if (inticon != null)
            {
                inticon.SetActive(true);
                
            }

            // Check for the "E" key press
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Check if key and inticon are not null before accessing them
                if (keye != null)
                {
                    
                    keye.SetActive(false);
                    keyfound=true;
                    keyf.SetActive(true);
                   
                }

                // Check if inticon is not null before accessing it
                if (inticon != null)
                {
                    inticon.SetActive(false);
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
