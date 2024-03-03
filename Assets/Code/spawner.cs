using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject  enermy;
    public float delay = 0;
    public  float wait = 0.3f;
    public float screensize;
    // Start is called before the first frame update
    void Start()
    {
        screensize = Camera.main.orthographicSize * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(delay <= 0){
            delay = wait;
float randY =Random.Range(-screensize,screensize);
Vector3 spawnPos = new Vector3(transform.position.x,randY,0);

            Instantiate(enermy,spawnPos,transform.rotation);
        } else{
            delay -= Time.deltaTime;
        }
    }
}
