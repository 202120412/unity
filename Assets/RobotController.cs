using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    Rigidbody2D robotRD;
    Animator animator;
    float walkSpeed = 2.0f;
    float jumpSpeed = 30.0f;
    float maxSpeed = 3.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        robotRD = GetComponent<Rigidbody2D> ();     
        animator = GetComponent<Animator> ();
        animator.speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        float speedx = Mathf.Abs (robotRD.velocity.x);

        if (speedx < maxSpeed) {
            if (Input.GetKey (KeyCode.LeftArrow) == true) {
                robotRD.AddForce (transform.right * -1 * walkSpeed);
                transform.localScale = new Vector3 (-1.0f , 1.0f , 1);
            }
            if (Input.GetKey (KeyCode.RightArrow) == true) {
                robotRD.AddForce (transform.right * walkSpeed);
                transform.localScale = new Vector3 (1.0f , 1.0f , 1);
            }
            if(Input.GetKey (KeyCode.Space) && transform.position.y <= -3.6f) {
                animator.SetTrigger("JumpCall");
                robotRD.AddForce(transform.up*jumpSpeed);
            }
            else
            {
                animator.ResetTrigger("JumpCall");

            }

        }
               
        animator.speed = speedx / 4.0f;
    }
}


