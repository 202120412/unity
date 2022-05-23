using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombMaker : MonoBehaviour
{
    public GameObject bombPrefab;
    float interval = 1.0f;
    float delta = 0;
        
    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta > interval) {
            delta = 0;
            GameObject bomb = Instantiate (bombPrefab);
            int x = Random.Range (-8 , 9);
            bomb.transform.position = new Vector3 (x , 6 , 0);
        }
    }
}
