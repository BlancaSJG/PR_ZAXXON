using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{

    //array con los prefabs de los obstaculos
    [SerializeField] GameObject[] arrayObst;

    //posicion del instanciador
    [SerializeField] Transform InitPos;

    int level;

    //intervalo de la corrutina que depende de la velocidad
    float intervalo;


    InitGameScript initGameScript;

    // Start is called before the first frame update
    void Start()
    {
        initGameScript = GameObject.Find("InitGame").GetComponent<InitGameScript>();

        //intervalo no fijo
        intervalo = 0.3f;

        StartCoroutine("InstObst");


    }

    // Update is called once per frame
    void Update()
    {
        
    }



    IEnumerator InstObst()
    {
        while (true)
        {


            //los objetos se instancian en valores random en  X e Y
            Vector3 instPos = new Vector3(Random.Range(-14f, 14f), Random.Range(-1f, 11f), InitPos.position.z);

            int randomObst;

            //nivel actual
            level = initGameScript.levelGame;

            if (level == 0)
            {
                randomObst = 0;

            } else if (level > 0 && level < 3)
            {
                randomObst = Random.Range(0, 3);

            } else
            {
                randomObst = Random.Range(0, arrayObst.Length);
            }

            //Instancio el prefab aleatorio en la posición calculada
            Instantiate(arrayObst[randomObst], instPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);


        }




    }


}
