using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myHeroScript : MonoBehaviour
{
    float runningSpeed = 3;
    float turningSpeed = 45;
   
    void Start()
    {
        transform.position += new Vector3(0,1,0);   
    }

   
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
            


            {
                transform.position += runningSpeed*transform.forward  * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -=  runningSpeed*transform.forward * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, runningSpeed*turningSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, runningSpeed*(-turningSpeed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += runningSpeed * transform.up * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position -= runningSpeed * transform.up * Time.deltaTime;
        }

    }
}
