using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using System;

public class delegates : MonoBehaviour
{
    // Start is called before the first frame update
    public delegate string test();
    private test testfunction;
    public string Currentpassword;
    public string expectedpasswords;
    void Start()

    {
        //stestfunction = Firsttest();
        testfunction();
    }   
     private void Firsttest(string text)
    {
        
        if (Currentpassword.Length < expectedpasswords.Length)
        {
            Currentpassword +=text ;
           // oncurrentpasswordchange?.Invoke(Currentpassword);
            CheckPassword();
            
        }
    }
    // Update is called once per frame
    private void CheckPassword()
    {
        if (Currentpassword==expectedpasswords)
        {
            
        }
    }
    void Update()
    {
        
    }
}
