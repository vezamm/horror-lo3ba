using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorwithbrokenknob : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject knob;
    public delegate void doorknob(bool haveknob =false);
    public static event doorknob knobhave;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            knob.SetActive(false);
            //haveknob=true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
