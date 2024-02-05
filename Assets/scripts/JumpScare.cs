using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class JumpScare : MonoBehaviour
{
    public AudioSource scream;
    public GameObject ThePlayer;
    public GameObject JumpCam;
    public GameObject Flashing;

    private void OnTriggerEnter(Collider other)
    {
        scream.Play();
        JumpCam.SetActive(true);
        ThePlayer.SetActive(false);
        Flashing.SetActive(true);
        StartCoroutine(EndJump());

    }
    IEnumerator EndJump()
    {

        yield return new WaitForSeconds(2f);
        ThePlayer.SetActive(true);
        JumpCam.SetActive(false);
        Flashing.SetActive(false);
    }
}