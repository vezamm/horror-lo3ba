using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    private Camera camera;
    public GameObject InText;
    // Start is called before the first frame update
    void Start()
    {
        camera= Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitinfo;
        var ray = camera.ScreenPointToRay(Input.mousePosition) ;
        if (Physics.Raycast(ray,out hitinfo, 5))
        {
            if (hitinfo.collider.CompareTag("Door"))
            {   
                InText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    //if (opened = true)
                    bloody_door door = hitinfo.collider.GetComponent<bloody_door>();
                    door.Open();                    
                }
                else InText.SetActive(false);
            }
            if(hitinfo.collider.CompareTag("codelock"))               
            {
                InText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    CodeLock padlock = hitinfo.collider.GetComponent<CodeLock>();
                    padlock.Canvason();
                }
                 else InText.SetActive(false);
            }
            if (hitinfo.collider.CompareTag("flash")) 
            {   
                InText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    dhaw flashi = hitinfo.collider.GetComponent<dhaw>();
                    flashi.Flashlightofftheground();
                    
                }
                else InText.SetActive(false);
            }
            /*if (hitinfo.collider.CompareTag("key1"))
            {
                if(Input.GetKeyDown(KeyCode.Mouse0)) 
                {
                    DoorKnob code = hitinfo.collider.GetComponent<DoorKnob>();
                    
                    Debug.Log("aaaaaaaaa");
                    code.Keyin();
                }
            }*/
           
        }
    }

}
