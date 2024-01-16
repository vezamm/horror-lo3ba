using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorwithbrokenknob : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject knob;
    public GameObject inText;
    public delegate void doorknob();
    public event doorknob Knobhave;
    public bool nob=false;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                inText.SetActive(true);
                knob.SetActive(false);
                Knobhave.Invoke();
                nob = true;
            }
            

            //haveknob=true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
