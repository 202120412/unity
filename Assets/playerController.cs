using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody playerRd;
    float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRd = GetComponent <Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)==true)
        {
            transform.Translate(Vector3.left*speed*Time.deltaTime);
        }
         if(Input.GetKey(KeyCode.RightArrow)==true)
        {
            transform.Translate(Vector3.right*speed*Time.deltaTime);
        }
        
        

    }
}
