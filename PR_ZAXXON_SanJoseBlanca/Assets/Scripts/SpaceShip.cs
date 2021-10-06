using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{


    //Variables para desplazamiento
    [SerializeField] float desplSpeed;

    float limiteR = 14;
    float limiteL = -14;
    float limiteU = 11;
    float limiteD = -1;

    bool inLimitH = true;
    bool inLimitV = true;


    //Variables para rotacion
    float rotAng = -6f;


    // Start is called before the first frame update
    void Start()
    {
        desplSpeed = 4f;
        
    }

    // Update is called once per frame
    void Update()
    {

        MoverNave();


        RotarNave();

    }

    void MoverNave()
    {
        // Control de movimiento 

        float desplH = Input.GetAxis("Horizontal");
        float desplV = Input.GetAxis("Vertical");

        //Calculo de posicion
        float posX = transform.position.x;
        float posY = transform.position.y;


        //Restriccion de movimiento con desplSpeed 

        /*transform.Translate(Vector3.right * desplSpeed * desplH * Time.deltaTime, Space.World);
        transform.Translate(Vector3.up * desplSpeed * desplV * Time.deltaTime, Space.World);*/


        /*if(posX >= limiteR && desplH > 0 || posX <= limiteL && desplH < 0 || posY >= limiteU && desplV > 0 || posY <= limiteD && desplV < 0)
        {
            desplSpeed = 0f;
        } 
        else
        {
            desplSpeed = 4f;
        }*/


        //Restriccion con bool
        if (inLimitH)
        {
            transform.Translate(Vector3.right * desplSpeed * desplH * Time.deltaTime, Space.World);
        }

        if (inLimitV)
        {
            transform.Translate(Vector3.up * desplSpeed * desplV * Time.deltaTime, Space.World);

        }

        //Restriccion en la Horizontal
        if (posX > limiteR && desplH > 0 || posX < limiteL && desplH < 0)
        {
            inLimitH = false;

        }
        else
        {
            inLimitH = true;
        }

        //Restriccion en la Vertical
        if (posY >= limiteU && desplV > 0 || posY <= limiteD && desplV < 0)
        {
            inLimitV = false;

        }
        else
        {
            inLimitV = true;
        }
    }

    void RotarNave()
    {
        // Rotacion con el movimiento

        float rotZ = Input.GetAxis("Horizontal") * rotAng;
        float rotX = Input.GetAxis("Vertical") * rotAng;

        // calculo de rotacion mediante quaternion
        Quaternion target = Quaternion.Euler(rotX, 0, rotZ);

        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);

    }

}
