using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyannimnumb : MonoBehaviour
{
    // Start is called before the first frame update
    public string numbers;
    public Animator animator;  
    void Start()
    {
           
    }
    public void Keyin()
    {

        animator.SetBool("keyin", true);
        //animator.SetBool("keyin", false);
        StartCoroutine(ResetButtonAnimation());
    }
    private IEnumerator ResetButtonAnimation()
    {
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);
        animator.SetBool("keyin", false);
    }    
    // Update is called once per frame
    void Update()
    {
        
    }
}
