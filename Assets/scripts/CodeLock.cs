using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CodeLock : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string expectedpasswords;
    [SerializeField] UnityEvent<string> oncurrentpasswordchange; 
    [SerializeField] UnityEvent passwordcorrect; 
    [SerializeField] UnityEvent passwordwrong;
    [SerializeField] UnityEvent ontrigger;
    private string Currentpassword;
   // public GameObject text;
    public GameObject canvas;


    public void EnterpasswordText(string text)
    {
        if (Currentpassword.Length < expectedpasswords.Length)
        {
            Currentpassword += text;
            oncurrentpasswordchange?.Invoke(Currentpassword);
            CheckPassword();
        }
    }
    public void ResetPassword()
    {
        Currentpassword = "";
        oncurrentpasswordchange?.Invoke(Currentpassword);
    }
    private void CheckPassword()
    {
        if (Currentpassword == expectedpasswords)
        {             
            passwordcorrect?.Invoke();
            //Cursor.lockState = CursorLockMode.Locked;
           // canvas.SetActive(false);
           // text.SetActive(false);
        }
        else if (Currentpassword.Length == expectedpasswords.Length)
        {
            passwordwrong?.Invoke();
            //ResetPassword();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // text.SetActive(true); ;
             if(Input.GetKeyDown(KeyCode.E))
            {
               canvas.SetActive(true);
               Cursor.lockState = CursorLockMode.None;
            }
            //ontrigger?.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.SetActive(false);
        }
    }

}
