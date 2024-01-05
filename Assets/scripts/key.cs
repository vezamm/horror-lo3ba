using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject inticon, keye;


    private void OnTriggerStay(Collider other)
    {
        if (CompareTag("MainCamera"))
        {

            inticon.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            { 
            
            keye.SetActive(false);
                Door.keyfound = true;
                inticon.SetActive(false);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (CompareTag("MainCamera"))
        {
            inticon.SetActive(false) ;
        }
    }
}
