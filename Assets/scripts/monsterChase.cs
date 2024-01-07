using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterChase : MonoBehaviour
{
    public Rigidbody rb;
    public Transform monsTrans , playerTrans;
    public int monSpeed;



    private void FixedUpdate()
    {
        rb.velocity=transform.forward*monSpeed*Time.deltaTime;
    }
    // Update is called once per frame
    void Update()
    {
        monsTrans.LookAt(playerTrans);
    }
}
