using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorwithbrokenknob : MonoBehaviour
{
    // Start is called before the first frame update
    public  Animator annimdoor;
    public GameObject knob;
    public AudioSource open;
    private void Start()
    {
              
    }
    
    public void Dooropen()
    {
            annimdoor.SetBool("open", true);
            knob.SetActive(true);
        open.Play();
    
    }
}
