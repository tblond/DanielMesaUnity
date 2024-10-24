using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsControl : MonoBehaviour
{
    float speed = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed*transform.forward * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= speed * transform.forward * Time.deltaTime;

        }
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"));

    }
}
