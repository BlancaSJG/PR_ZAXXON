using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreacionMuro : MonoBehaviour
{
    /*[SerializeField] GameObject ladrillo;
    [SerializeField] Transform initPos;

    float separacion ;

    //Numero de filas y de ladrillos por filas
    [SerializeField] int numLadrillos = 10;
    [SerializeField] int numFilas = 5;
    [SerializeField] int numColumnas = 3;*/


    [SerializeField] GameObject asteroides;
    [SerializeField] Transform InitPos;


    // Start is called before the first frame update
    void Start()
    {

        



       // StartCoroutine("Instanciador");

    }


    // Start is called before the first frame update
    /*void Start()
    {

        //Muro 

        separacion = 3f;

        //Posición en Y para las filas
        float desplY = 0f;

        //Las posición inicial es la del objeto de referencia
        Vector3 newPos = initPos.position;
        //Creo el Vector que moverá cada instancia
        Vector3 despl = new Vector3(0f, desplY, separacion);


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
        }


        for (int i = 0; i < numColumnas; i++)
        {

            Vector3 columna = new Vector3();
        }

    }*/

    // Update is called once per frame
    void Update()
    {
        
    }


    /*IEnumerator Instanciador()
    {



        Vector3 NewPos;

        //Instanciacion en x
        /*for (int n = 0; n < 30; n++)
        {
            float sep = Random.Range(1, 22);
            
            Vector3 CambioPos = new Vector3(sep, 0f, 0f);
            NewPos = InitPos.position + CambioPos;
            Instantiate(asteroides, NewPos, Quaternion.identity);

            //Separacion aleatoria entre asteroides
            sep += Random.Range(0, 22);

            yield return new WaitForSeconds(1f);

        }*/

        /*while (true)
        {
            for (int x = 0; x < 3; x++)
            {
                float alt = 0f;

                for (int n = 0; n < 3; n++)
                {
                    float sep = 0f;

                    

                    Vector3 CambioPos = new Vector3(11f, alt, sep);
                    NewPos = InitPos.position + CambioPos;
                    Instantiate(asteroides, NewPos, Quaternion.identity);

                   

                    //Separacion aleatoria entre asteroides
                    sep += Random.Range(3, 30);
                    alt += Random.Range(-1, 30);
                }

               

            }

            

            yield return new WaitForSeconds(1f);

        }

    }*/


}
