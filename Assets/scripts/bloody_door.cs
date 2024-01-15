using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloody_door : MonoBehaviour
{
    private Animator animator;
    public GameObject intText;
    public bool opened;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); 
        opened = animator.GetBool("open");
    }
    private void Update()
    {
        opened = animator.GetBool("open");
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {  
            intText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (opened == false)
                {
                    animator.SetBool("open", true);
                }
                else animator.SetBool("open", false);
                
            }
        }
        
               

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            intText.SetActive(false);
        }
    }
    

}

