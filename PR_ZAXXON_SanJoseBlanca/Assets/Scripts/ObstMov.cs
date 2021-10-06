using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstMov : MonoBehaviour
{
    [SerializeField] GameObject initObject;
    InitGameScript initGameScript;
    float speed;


    // Start is called before the first frame update
    void Start()
    {
        initObject = GameObject.Find("InitGame"); //asociar al GameObject sin arrastrar

        initGameScript = initObject.GetComponent<InitGameScript>();

        speed = initGameScript.spaceshipSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        speed = initGameScript.spaceshipSpeed;
        transform.Translate(Vector3.back * speed * Time.deltaTime/*, Space.World*/);


        float posZ = transform.position.z;        

        if (posZ < -10)
        {
            Destroy(gameObject);
        }


    }
}
