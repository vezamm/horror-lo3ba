using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorwithlock : MonoBehaviour
{
    private Animator animator;
    public AudioSource open;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Beb()
    {
        animator.SetBool("open", true);
        open.Play();
    }
    public void Cursorlock()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    

    
    // Update is called once per frame
}
