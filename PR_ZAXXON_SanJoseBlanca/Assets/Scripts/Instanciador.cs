using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{

    //array con los prefabs de los obstaculos
    [SerializeField] GameObject[] arrayObst;

    //posicion del instanciador
    [SerializeField] Transform InitPos;

    //array para objetivos
    [SerializeField] GameObject[] arrayTarg;

    //intervalo de la corrutina que depende de la velocidad
    float intervalo;
    [SerializeField] float distObst;

    float distPrimObst;

    InitGameScript initGameScript;
    
    int level;

    // Start is called before the first frame update
    void Start()
    {
        initGameScript = GameObject.Find("InitGame").GetComponent<InitGameScript>();
        

        distObst = 30f;
        intervalo = distObst / initGameScript.spaceshipSpeed;

        distPrimObst = 0f;
        float numObstInit = (transform.position.z - distPrimObst) / distObst * 10;
        print(numObstInit);

        StartCoroutine("InstObst");

        StartCoroutine("InstParedIzd");

        StartCoroutine("InstParedDrch");

        StartCoroutine("InstSuelo");

        StartCoroutine("InstTecho");

        

        //obstaculos intermedios
        for (float i = 0; i <= numObstInit; i++)
        {
            Vector3 instPos = new Vector3(Random.Range(-30f, 30f), Random.Range(-10f, 12f), Random.Range(35f, 300f));

            int randomObst;

            randomObst = Random.Range(0, arrayObst.Length);


            Instantiate(arrayObst[randomObst], instPos, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }



    IEnumerator InstObst()
    {
               

        //contador de vueltas
        int contadorVueltas = 0;

        while (true)
        {
            /*---------------Instanciacion obstaculos--------------------*/

            //los objetos se instancian en valores random en  X e Y

            float instPosX = Random.Range(-16f, 16f);
            float instPosY = Random.Range(-2f, 12f);
            Vector3 instPos = new Vector3(instPosX, instPosY, InitPos.position.z);



            int randomObst;

            //nivel actual
            level = initGameScript.levelGame;


            if (level == 0)
            {
                randomObst = 0;

            }
            else if (level > 0 && level < 3 )
            {
                randomObst = Random.Range(0, 2);

            }
            else
            {
                randomObst = Random.Range(0, arrayObst.Length);
            }

            //calculo del intervalo a cada vuelta de la corrutina
            distObst = 3f;
            intervalo = distObst / initGameScript.spaceshipSpeed;

            

            //Instancio el prefab aleatorio en la posicion calculada
            Instantiate(arrayObst[randomObst], instPos, Quaternion.identity);

            
            /*------------------Instanciacion objetivos----------------------*/

            //posicion de instanciado de objetivos
            float instTargPosX = Random.Range(-16f, 16f);
            float instTargPosY = Random.Range(-2f, 12f);

            
            Vector3 instTargPos = new Vector3(instTargPosX, instTargPosY, InitPos.position.z);

            //obtetivos random
            int randomTarg = Random.Range(0, 2);

            //los objetivos salen a las 50 vueltas y si se instancian en una posicion diferente a la de los obstaculos
            if (contadorVueltas == 50 && instTargPos != instPos)
            {
                Instantiate(arrayTarg[randomTarg], instTargPos, Quaternion.identity);
                contadorVueltas = 0;
            }

            contadorVueltas++;

            yield return new WaitForSeconds(intervalo);


        }




    }

    //Instanciacion de objetos fuera de los limites
    IEnumerator InstParedIzd()
    {
        while (true)
        {


            
            Vector3 instPos = new Vector3(Random.Range(-30f, -17f), Random.Range(-2f, 12f), InitPos.position.z);

            int randomObst;

            randomObst = Random.Range(0, arrayObst.Length);

            
            Instantiate(arrayObst[randomObst], instPos, Quaternion.identity);

            yield return new WaitForSeconds(0.4f);


        }


    }

    IEnumerator InstParedDrch()
    {
        while (true)
        {


            
            Vector3 instPos = new Vector3(Random.Range(17f, 30f), Random.Range(-2f, 12f), InitPos.position.z);

            int randomObst;

            randomObst = Random.Range(0, arrayObst.Length);

            
            Instantiate(arrayObst[randomObst], instPos, Quaternion.identity);

            yield return new WaitForSeconds(0.4f);


        }


    }

    IEnumerator InstSuelo()
    {
        while (true)
        {

            
            
            Vector3 instPos = new Vector3(Random.Range(-22f, 22f), Random.Range(-10f, -2f), InitPos.position.z);

            int randomObst;

            randomObst = Random.Range(0, arrayObst.Length);

            
            Instantiate(arrayObst[randomObst], instPos, Quaternion.identity);

            yield return new WaitForSeconds(0.4f);


        }


    }

    IEnumerator InstTecho()
    {
        while (true)
        {



            Vector3 instPos = new Vector3(Random.Range(-22f, 22f), Random.Range(12f, 20f), InitPos.position.z);

            int randomObst;

            randomObst = Random.Range(0, arrayObst.Length);


            Instantiate(arrayObst[randomObst], instPos, Quaternion.identity);

            yield return new WaitForSeconds(0.4f);


        }


    }


}
