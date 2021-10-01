using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    [SerializeField] float desplSpeed;

    float limiteR = 14;
    float limiteL = -14;
    float limiteU = 11;
    float limiteD = -1;


    // Start is called before the first frame update
    void Start()
    {
        desplSpeed = 4f;
    }

    // Update is called once per frame
    void Update()
    {


        // Control de movimiento con teclas

        /*if (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow)) // Frente
        {
            this.transform.Translate(Vector3.up * desplSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow)) // Después
        {
            this.transform.Translate(Vector3.up * -desplSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow)) // Izquierda
        {
            this.transform.Translate(Vector3.right * -desplSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow)) // Derecha
        {
            this.transform.Translate(Vector3.right * desplSpeed * Time.deltaTime);
        }*/

        float desplH = Input.GetAxis("Horizontal");
        float desplV = Input.GetAxis("Vertical");

        //Calculo de posicion
        float posX = transform.position.x;
        float posY = transform.position.y;


        transform.Translate(Vector3.right * desplSpeed * desplH * Time.deltaTime, Space.World);
        transform.Translate(Vector3.up * desplSpeed * desplV * Time.deltaTime, Space.World);

        //Restriccion de movimiento 

        if(posX >= limiteR && desplH > 0 || posX <= limiteL && desplH < 0 || posY >= limiteU && desplV > 0 || posY <= limiteD && desplV < 0)
        {
            desplSpeed = 0f;
        } 
        else
        {
            desplSpeed = 4f;
        }

        






    }
}
