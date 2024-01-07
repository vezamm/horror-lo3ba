using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUMPSCARE1 : MonoBehaviour
{
    public GameObject JumpScareImg;
    public AudioSource scream;
    // Start is called before the first frame update
    void Start()
    {
        JumpScareImg.SetActive(false);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag ==" Player") 
        {
            JumpScareImg.SetActive(true);
            StartCoroutine(DisableImg());
            scream.Play();
        }
    }
    IEnumerator DisableImg()
    {
        yield return new WaitForSeconds (2);
        JumpScareImg.SetActive(false);
    }

}
