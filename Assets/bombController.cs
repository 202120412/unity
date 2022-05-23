using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombController : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D Col)
    {
        GameObject hp = GameObject.Find ("HPControl");

        if (Col.gameObject.tag == "ROBOT") {
            hp.GetComponent<hpController> ().HpControl ();
        }

        Destroy (gameObject);
    }
}
