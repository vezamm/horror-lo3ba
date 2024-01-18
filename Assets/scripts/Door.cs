using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door_closed, door_opened, intText, lockedtext,keyf;
    public AudioSource open, close;
    public bool opened, locked;
    public bool keymawjouda;
    private void Start()
    {
        keymawjouda = false;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (!opened)
            {
                if (!locked)
                {


                    intText.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        door_closed.SetActive(false);
                        door_opened.SetActive(true);
                        intText.SetActive(false);
                        StartCoroutine(Repeat());
                        opened = true;
                    }
                }
                if (locked == true)
                {
                    lockedtext.SetActive(true);
                }
                
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            lockedtext.SetActive(false);
        }
    }

    IEnumerator Repeat()
    {
        yield return new WaitForSeconds(2.0f);
        opened = false;
        door_closed.SetActive(true);
        door_opened.SetActive(false);
    }
    
    private void Update()
    {
        if (keyf.activeSelf)
        //if (keymawjouda == true)
        {
            locked = false;
        }
        bool a = GetComponent<key>();
        if (a != null)
        {
          //s  a = keyfound;
        }
        
    }

}

