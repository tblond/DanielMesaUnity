using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdAnimationScript : MonoBehaviour
{
    Animator edAnimator;
    float forwardSpeed = 1.5f;
    float backwardSpeed = .5f;
    float runningSpeed = 3f;
    float turningSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        edAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        edAnimator.SetBool("isWalking",false);
        if (Input.GetKey(KeyCode.W))
        {
            //Make Ed walk in animations and move forward
            edAnimator.SetBool("isWalking", true);
            transform.position += forwardSpeed * transform.forward * Time.deltaTime;

        }
        edAnimator.SetBool("isWalkingBackward", false);
        if (Input.GetKey(KeyCode.S))

        {
            //Make Ed walk in animations and move forward
            edAnimator.SetBool("isWalkingBackward", true);
            transform.position -= backwardSpeed * transform.forward * Time.deltaTime;
            

        }
        edAnimator.SetBool("isRunning", false);
        if (Input.GetKey(KeyCode.W) && Input.GetKey (KeyCode.LeftShift))

        {
            //Make Ed walk in animations and move forward
            edAnimator.SetBool("isRunning", true);
            transform.position += runningSpeed * transform.forward * Time.deltaTime;


        }
        edAnimator.SetBool("greet", false);
        if (Input.GetKeyDown(KeyCode.B))
        {
            //make character greet
            edAnimator.SetBool("greet", true);
            

        }
         if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down, runningSpeed * turningSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.down, runningSpeed * (-turningSpeed) * Time.deltaTime);
        }

    }
}
