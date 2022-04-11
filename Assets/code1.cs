using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     int [] score = {100, 50, 80,90,95};

     score[1] = 70;

     for (int index = 0; index < 5; index++)
     {
       Debug.Log (score[index]);
     } 
    }

    void Update()
    {
      
    }
}