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
        if(Input.GetKey(KeyCode.Space)==true)
        {
            playerRd.AddForce(0f,speed,0f);
        }
    }
}
