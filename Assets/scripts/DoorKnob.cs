using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKnob : bloody_door
{
    // Start is called before the first frame update
    [SerializeField] private doorwithbrokenknob knob;   
    void Start()
    {
        knob.Knobhave += Open;
    }
    
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
