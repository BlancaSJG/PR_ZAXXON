using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciator : MonoBehaviour
{
    [SerializeField] GameObject asteroides;
    [SerializeField] Transform InitPos;

    // Start is called before the first frame update
    void Start()
    {

        asteroides = GameObject.Find("Obstaculo");

        

        StartCoroutine("Instanciador");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Instanciador()
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

        while (true)
        {
            for (int x = 0; x < 2; x++)
            {
                float alt = 0f;

                for (int n = 0; n < 2; n++)
                {
                    float sep = 0f;

                    //Separacion aleatoria entre asteroides
                    sep += Random.Range(-11, 22);
                    alt += Random.Range(-11, 22);

                    Vector3 CambioPos = new Vector3(sep, alt, 0f);
                    NewPos = InitPos.position + CambioPos;
                    Instantiate(asteroides, NewPos, Quaternion.identity);                
     

                    

                }


            }
                    
            yield return new WaitForSeconds(1f);

        }
        

        

        



        


    }





}
