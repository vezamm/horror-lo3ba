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
    public GameObject text;
    public bool havekey=false;
    public GameObject key;
    [SerializeField] playermove playermovescript;
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
                //InText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    //if (opened = true)
                    bloody_door door = hitinfo.collider.GetComponent<bloody_door>();
                    door.Open();                    
                }
                //else InText.SetActive(false);
            }
          
            if(hitinfo.collider.CompareTag("codelock"))//opening the canvas for the code lock   
            {
                //InText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {   
                    playermovescript.Togglecamrot(false);
                    CodeLock padlock = hitinfo.collider.GetComponent<CodeLock>();
                    
                    padlock.Canvason();
                }
                 //else InText.SetActive(false);
            }
           
            if (hitinfo.collider.CompareTag("flash")) //picking up the flashlight
            {   
                //InText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    dhaw flashi = hitinfo.collider.GetComponent<dhaw>();
                    flashi.Flashlightofftheground();
                    
                }
                //kelse InText.SetActive(false);
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
                    text.SetActive(true);
                }
                if (Input.GetKeyDown(KeyCode.E) && havedoorknob == true)
                {
                    knob.Dooropen();
                }
            }
            else text.SetActive(false);
            if (hitinfo.collider.CompareTag("keydoor"))
            {   
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Key();
                    Destroy(hitinfo.collider.gameObject);
                }              
            }
            if (hitinfo.collider.CompareTag("doorwithoutkey"))
            {
                doorwithbrokenknob knob = hitinfo.collider.GetComponentInChildren<doorwithbrokenknob>();
                if(havekey==false)text.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E) && havekey == true)
                {
                    knob.Dooropen();
                }
                else text.SetActive(false);
                
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
