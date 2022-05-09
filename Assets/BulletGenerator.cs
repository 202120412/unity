using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{

    public GameObject bulletprefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown (0))
        {
            
            GameObject bullet = Instantiate (bulletprefab , transform.position , transform.rotation);

            //BulletController 스크립트를 찾아서 Shoot() 함수 호출 (총알 발사)
            bullet.GetComponent<BulletController>().Shoot (new Vector3(0,0,500));
        }
        
    }
}

