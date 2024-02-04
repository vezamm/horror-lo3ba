using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloody_door : MonoBehaviour
{
    public Animator animator;
    public bool opened;
    public AudioSource open;

    void Start()
    {
        opened = animator.GetBool("open");
        open = GetComponent<AudioSource>(); // Assuming AudioSource is attached to the same GameObject
    }

    private void FixedUpdate()
    {
        opened = animator.GetBool("open");
    }

    public void Open()
    {
        if (!opened)
        {
            animator.SetBool("open", true);
            if (open != null && !open.isPlaying) // Check if AudioSource is not null and not already playing
            {
                open.Play();
            }
        }
        else
        {
            animator.SetBool("open", false);
        }
    }
}
