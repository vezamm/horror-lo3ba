using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using static doorwithbrokenknob;

public class entre : MonoBehaviour
{
    // Start is called before the first frame update
   // public int keynum;    
   // public bool keyout;
    private Camera cam;
    public string enteredcode,enteredcodecolor;
    public string expectedcode,expectedcodecolor;
    public Animator animdoor;public Animator animdoorcolor;
    public TMP_Text display;

    // Update is called once per frame
     void Start()
    {   
               cam= Camera.main;
    }
    /*public void Keyin()
    {
        
        animator.SetBool("keyin", true);
       
    }*/
    public void Update()
    {
        RaycastHit hitinfo;
        var ray = cam.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hitinfo, 5))
        {
            if (hitinfo.collider.CompareTag("key1"))
            {
                if (Input.GetKeyDown(KeyCode.Mouse0)) { 

                    DoorKnob doorknob = hitinfo.collider.GetComponent<DoorKnob>();
                    if (doorknob != null)
                    {   
                        doorknob.Keyin();
                        //enteredcode += doorknob.numbers;
                        Addnumber(doorknob.numbers);
                        Displaycode();
                        Checklenghtcode();
                    }
                }
            }
            if (hitinfo.collider.CompareTag("keycolor"))
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    DoorKnob doorKnob =hitinfo.collider.GetComponent<DoorKnob>();
                    if(doorKnob != null)
                    {
                        doorKnob.Keyin();
                        AddnumberColor(doorKnob.numbers);
                        Checklenghtcodecolor();
                        
                    }
                }
            }
        } 

    }
    public void Checklenghtcode ()  
    {
        if (enteredcode.Length == expectedcode.Length)
        {
            Checkcode();
        }
        
    }
    public void Checkcode()
    {                             
          if (enteredcode == expectedcode)
          {
             animdoor.SetBool("open", true);

                    
          }
          else  enteredcode = "";                             
    }
    
    private void Addnumber(string keynumbers)
    {
        enteredcode += keynumbers;
        

    }
    private void AddnumberColor(string keycolor)
    {
        enteredcodecolor += keycolor;
    }
    public void Displaycode()
    {
        if (display != null)
        {
            display.text = $"{enteredcode:OOOO}";
        }
    }

    public void Checkcodecolor()
    {
        if (enteredcodecolor == expectedcodecolor)
        {
            animdoorcolor.SetBool("open", true);


        }
        else enteredcode = "";
    }
    public void Checklenghtcodecolor()
    {
        if (enteredcodecolor.Length == expectedcodecolor.Length)
        {
            Checkcodecolor();
        }

    }

}
