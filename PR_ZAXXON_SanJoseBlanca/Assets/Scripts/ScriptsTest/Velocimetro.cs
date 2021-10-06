using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocimetro : MonoBehaviour
{

    bool moving = true;
    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 0f, 0f);
    }

    

    // Update is called once per frame
    void Update()
    {
        float tt = Time.time;

        if (moving)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        if (tt >= 10)
        {
            moving = false;
            print("tiempo: "+Time.time);
            print("posicion: "+transform.position.z);

            float posZ = transform.position.z / 1000;

            print("velocidad: "+posZ);
        }
       
    }
}
