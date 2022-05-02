using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
       {
           Shoot (new Vector3 (0,0,20));
       } 
    }
    // 총알 발사 함수
    public void Shoot (Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    void OnCollisionEnter (Collision coll)
    {
        if (coll.collider.tag == "ENEMY")
        {
            Destroy (gameObject, 0.2f); // 오브젝트 파괴  
        }
    }
    
}
