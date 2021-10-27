using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InitGameScript : MonoBehaviour
{
    //variable velocidad de la nave (del juego)
    public float spaceshipSpeed;
    [SerializeField] float maxSpeed;

    //variable nivel del juego
    public int levelGame;

    //puntuacion 
    static float score;

    //estado
    public bool alive;

    //UI
    [SerializeField] Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        levelGame = 0;
        spaceshipSpeed = 20f;
        maxSpeed = 40f;

        //para que en el HS no tenga problemas score = 0;
        alive = true;

        //para que no de problemas concatenar con un tx
        scoreText.text = score + "m"; 


    }

    // Update is called once per frame
    void Update()
    {
        

        if(spaceshipSpeed < maxSpeed && alive == true)
        {
            spaceshipSpeed += 0.001f;
        }

        //segundos que pasan 
        float tiempo = Time.time;

        //puntuacion basada en los metros recorridos
        score = Mathf.Round(tiempo) * spaceshipSpeed;
        
        scoreText.text = score + "m";


    }


    //Morirse
    public void Morir()
    {
        alive = false;
        spaceshipSpeed = 0f;
        

    }
}
