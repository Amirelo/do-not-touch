using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public GameObject bow;
    
    void OnTriggerEnter2D(Collider2D collider){
        if (collider.tag == "Enermy"){
            Destroy(bow);
            Destroy(gameObject);

        }
    }
}
