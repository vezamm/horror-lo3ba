using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.UI;

public class Raycasting : MonoBehaviour
{
    private Camera camera;
   // public GameObject InText;
    public GameObject knob;
    public bool havedoorknob=false;
    public GameObject needsknobtext,needskeytext,pressEtext;
    public bool havekey=false;
    public GameObject key;
    [SerializeField] playermove playermovescript;
    public key keysscript;
    public bloody_door bloody_Doorscript;
        
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
            if (hitinfo.collider.CompareTag("Door"))//openning the door
            {   
                pressEtext.SetActive(true);                
                if (Input.GetKeyDown(KeyCode.E))
                {
                    //if (opened = true)
                    bloody_door door = hitinfo.collider.GetComponent<bloody_door>();
                    door.Open();                    
                }               
            }else pressEtext.SetActive(false);
          
            if(hitinfo.collider.CompareTag("codelock"))//opening the canvas for the code lock   
            { 
                pressEtext.SetActive(true);
                //InText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {   
                    playermovescript.Togglecamrot(false);
                    CodeLock padlock = hitinfo.collider.GetComponent<CodeLock>();
                    
                    padlock.Canvason();
                }

            }

           
            if (hitinfo.collider.CompareTag("flash")) //picking up the flashlight
            {   
                //InText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    dhaw flashi = hitinfo.collider.GetComponent<dhaw>();
                    flashi.Flashlightofftheground();
                    
                }
                
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
            
            if (hitinfo.collider.CompareTag("knob"))//picking up the doorknob
            {   
                if (Input.GetKeyDown(KeyCode.E))
                {

                     Keyknob();
                     Destroy(hitinfo.collider.gameObject);
                }
            }

            if (hitinfo.collider.CompareTag("doorwithoutknob"))//opening the door with the brokendoorknob
            {
                doorwithbrokenknob knob = hitinfo.collider.GetComponentInChildren<doorwithbrokenknob>();
                if (havedoorknob == false)
                {
                    needsknobtext.SetActive(true);
                }
                if (Input.GetKeyDown(KeyCode.E) && havedoorknob == true)
                {
                    knob.Dooropen();
                }
            }else needsknobtext.SetActive(false);
            if (hitinfo.collider.CompareTag("keydoor"))
            {
                pressEtext.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Key();
                    Destroy(hitinfo.collider.gameObject);
                }
            }//else pressEtext.SetActive(false);
            if (hitinfo.collider.CompareTag("doorwithoutkey"))
            {
                doorwithbrokenknob knob = hitinfo.collider.GetComponentInChildren<doorwithbrokenknob>();
                if(havekey==false)needskeytext.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E) && havekey == true)
                {
                    knob.Dooropen();
                }                               
            }else needskeytext.SetActive(false);
          
            if(hitinfo.collider.CompareTag("keydoorsafeside"))
            { 
               pressEtext.SetActive(true);
                if(Input.GetKeyDown(KeyCode.E))
                {
                    keysscript.Keyfound();
                }
            }
           
            if (hitinfo.collider.CompareTag("safedoorwithoutkey"))
            {
                if (keysscript.keytaken == false) needskeytext.SetActive(true);
                else
                {
                    pressEtext.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.E) && keysscript.keytaken == true)
                    {
                        bloody_Doorscript.Open();
                    }
                }
            }
            
        }
    }
    public void Key()
    {
        key.SetActive(false);
        havekey= true;
    }
    public void Keyknob()
    {
        knob.SetActive(false);
        havedoorknob = true;

    }
}
