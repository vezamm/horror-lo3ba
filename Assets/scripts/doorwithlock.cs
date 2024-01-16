using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorwithlock : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Beb()
    {
        animator.SetBool("open", true);
    }
    public void Cursorlokc()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    

    
    // Update is called once per frame
}
