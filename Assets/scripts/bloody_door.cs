using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloody_door : MonoBehaviour
{
    public Animator animator;
    public GameObject intText;
    public bool opened;
    // Start is called before the first frame update
    void Start()
    {
       // animator = GetComponent<Animator>(); 
        opened = animator.GetBool("open");
    }
    private void FixedUpdate() 
    {
        opened = animator.GetBool("open");
    }

    // Update is called once per frame
   /* private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {  
            intText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (opened == false)
                {
                    Open();
                }
                else Close();
                
            }
        }
    }*/

    public void Open()
    {
        if (opened == false)
        {
            animator.SetBool("open", true);
            Debug.Log("raycasttodhreb");
            //opened = false;
        }
        if (opened==true)
        {
            Debug.Log("kada tekhdem");
            animator.SetBool("open", false);
           //opened = true;
        }
    }
    /*public void Close()
    {
        animator.SetBool("open", false);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            intText.SetActive(false);
        }
    }*/

}

