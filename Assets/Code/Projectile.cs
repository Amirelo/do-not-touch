using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,speed * Time.deltaTime,0);
    }

    void OnTriggerEnter2D(Collider2D collider){
        if (collider.tag == "Enermy"){
            Destroy(collider.gameObject);
            Destroy(gameObject);
        }
    }
}
