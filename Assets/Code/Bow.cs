using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public GameObject  arrow;
    public float delay = 0;
    public  float wait = 0.3f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector2 screenPos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 crossbowPos = transform.position;
        Vector2 lookDirection = screenPos - crossbowPos;
        Vector2 defaultPos = new Vector2(0,1);

        float angle = Vector2.SignedAngle(defaultPos, lookDirection);
        Vector3 newEuler = new Vector3(0,0, angle);
        transform.localEulerAngles = newEuler;


        if(delay <= 0){
            delay = wait;
            Instantiate(arrow,transform.position,transform.rotation);
        } else{
            delay -= Time.deltaTime;
        }
    }
}
