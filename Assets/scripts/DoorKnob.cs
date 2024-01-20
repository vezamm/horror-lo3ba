using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKnob : MonoBehaviour
{
    // Start is called before the first frame update
    public string numbers;
    public Animator animator;
   // public string colors;
    //public  Animator animdoor;
    void Start()
    {
           
    }
    public void Keyin()
    {

        animator.SetBool("keyin", true);
        //animator.SetBool("keyin", false);
    }
    /*public  void Opendoor()
    {
        animdoor.SetBool("open", true);
    }
    public void OpenDoorcolor()
    {

    }*/
    // Update is called once per frame
    void Update()
    {
        
    }
}
