using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class Test : MonoBehaviour
 {
     void Start()
     {
         Vector2 playerPos = new Vector2(3.0f, 4.0f);
         playerPos.x += 8.0f;
         playerPos.y += 5.0f;
         Debug.Log(playerPos);

     }
 }