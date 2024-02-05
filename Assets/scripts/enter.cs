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

    private Camera cam;
    public string enteredcode,enteredcodecolor;
    public string expectedcode,expectedcodecolor;
    public Animator animdoor;public Animator animdoorcolor;
    public TMP_Text display,displayC;

    // Update is called once per frame
     void Start()
     {   
               cam= Camera.main;
     }
    
    public void Update()
    {
        RaycastHit hitinfo;
        var ray = cam.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hitinfo, 5))
        {
            if (hitinfo.collider.CompareTag("key1"))
            {
                if (Input.GetKeyDown(KeyCode.Mouse0)) { 

                    keyannimnumb doorknob = hitinfo.collider.GetComponent<keyannimnumb>();
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
                    keyannimnumb doorKnob =hitinfo.collider.GetComponent<keyannimnumb>();
                    if(doorKnob != null)
                    {
                        doorKnob.Keyin();
                        AddnumberColor(doorKnob.numbers);
                        Checklenghtcodecolor();
                        DisplaycodeCOLOR();
                    }
                }
            }
            if (hitinfo.collider.CompareTag("reset"))
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    Resetcode();
                Debug.Log("eee");
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
             display.text = expectedcode;
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
    public void DisplaycodeCOLOR()
    {
        if (displayC != null)
        {
            displayC.text = $"{enteredcodecolor:....}";
        }
    }

    public void Checkcodecolor()
    {
        if (enteredcodecolor == expectedcodecolor)
        {
            animdoorcolor.SetBool("open", true);


        }
        else enteredcodecolor = "";
    }

    public void Checklenghtcodecolor()
    {
        if (enteredcodecolor.Length == expectedcodecolor.Length)
        {
            Checkcodecolor();
        } 

    }
    public void Resetcode()
    {
        enteredcode = "";
        display.text = "";
    }

}
