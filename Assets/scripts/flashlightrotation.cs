using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlightrotation : MonoBehaviour
{
    public float lookSpeed = 2.0f;
    public float lookXLimit = 50.0f;
    float rotationX = 0;
    public GameObject flashlight;
    [SerializeField] private playermove playermovescript;
    // Update is called once per frame
    void Update()
    {
        if (playermovescript.allowcamerarotation == true)
        {  
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            flashlight.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);     
        
        }

    }
}
