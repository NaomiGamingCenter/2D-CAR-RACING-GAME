using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carspawn : MonoBehaviour
{    
    public GameObject car;
    public float maxPosition = 8.2f;
    public float delayTimer =100f;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
      timer = delayTimer;    
    }

    // Update is called once per frame
    void Update()
    {   timer -= Time.deltaTime;
        if (timer <= 0)
        { 
            Vector3 carPos = new Vector3 (Random.Range(-8.2f,8.2f),transform.position.y, transform.position.z); 

            Instantiate (car, carPos, transform.rotation); 

             timer = delayTimer;
          
        }
       
    }
}
