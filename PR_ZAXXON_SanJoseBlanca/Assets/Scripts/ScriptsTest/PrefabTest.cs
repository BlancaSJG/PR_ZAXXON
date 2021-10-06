using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    [SerializeField] GameObject ladrillo;
    [SerializeField] Transform initPos;

    float separacion;

    //Numero de filas y de ladrillos por filas
    [SerializeField] int numLadrillos = 10;
    [SerializeField] int numFilas = 5;


    // Start is called before the first frame update
    void Start()
    {
        /*Vector3 NewPos;

        float sep = 0f;
        float alt = 0f;

        for(int x = 0; x < 4 ; x++)
        {
            for(int n = 0; n < 5; n++)
            {
                Vector3 CambioPos = new Vector3(alt, 0f, sep);
                NewPos = initPos.position + CambioPos;
                Instantiate(ladrillo, NewPos, Quaternion.identity);

                //Separacion aleatoria entre ladrillos
                sep += Random.Range(2, 5);
                alt += Random.Range(2, 5);



                
            }


        }*/

        //Muro 

        /*separacion = 1.1f;

        //Posición en Y para las filas
        float desplY = 0f;

        //Las posición inicial es la del objeto de referencia
        Vector3 newPos = initPos.position;
        //Creo el Vector que moverá cada instancia
        Vector3 despl = new Vector3(separacion, desplY, 0f);


        //Creo un bucle con las filas
        for (int f = 0; f < numFilas; f++)
        {
            Vector3 fila = new Vector3(0f, desplY, 0f);

            //Bucle para instanciar ladrillos
            for (int n = 0; n < numLadrillos; n++)
            {

                Instantiate(ladrillo, newPos, Quaternion.identity);
                newPos = newPos + despl;
            }

            newPos = initPos.position + fila;


            desplY += separacion;
        }*/




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
