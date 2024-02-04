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
   // [SerializeField] playermove playermovescript;
   // public GameObject text;
    public GameObject canvas;


    public void EnterpasswordText(string Text)
    {      
            if (Currentpassword.Length < expectedpasswords.Length)
            {
                Currentpassword += Text;
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
            for (int i = 0; i < 4; i++) 
            {
                ResetPassword();
                if (i == 3)
                {                 
                      passwordwrong?.Invoke();
                }
            }
            
        }
    }  
    public void Canvason()
    {
        canvas.SetActive(true );
        Cursor.lockState = CursorLockMode.None;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.SetActive(false);
        }
    }

}
