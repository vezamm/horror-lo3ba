using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    private Camera camera;
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
        if (Physics.Raycast(ray,out hitinfo, 3))
        {
            if (hitinfo.collider.CompareTag("Door")&&Input.GetKeyDown(KeyCode.E))
            {
                //if (opened = true)
                bloody_door door = hitinfo.collider.GetComponent<bloody_door>();  
                door.Open();
                
            }
            if(hitinfo.collider.CompareTag("codelock")&&Input.GetKeyDown(KeyCode.E))
            {
                CodeLock  aaa= hitinfo.collider.GetComponent<CodeLock>();
                aaa.Canvason();
            }
        }
    }
}
