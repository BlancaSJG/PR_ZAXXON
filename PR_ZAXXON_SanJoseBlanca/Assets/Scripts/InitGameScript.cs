using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InitGameScript : MonoBehaviour
{

    [SerializeField] GameObject shipParent;

    //variable velocidad de la nave (del juego)
    public float spaceshipSpeed;
    [SerializeField] float maxSpeed;

    //variable nivel del juego
    public int levelGame;

    //distancia
    static float dist;

    //target es la cantidad de basura que recoges
    int target;

    //estado
    public bool alive;

    //UI
    [SerializeField] Text distText;
    [SerializeField] Text levelText;
    [SerializeField] Text targetText;
    [SerializeField] GameObject gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        shipParent.SetActive(true);

        levelGame = 0;
        spaceshipSpeed = 20f;
        maxSpeed = 40f;

        //para que en el HS no tenga problemas score = 0;
        alive = true;

        //para que no de problemas concatenar con un tx
        distText.text = dist + "m";

        gameOver.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        

        if(spaceshipSpeed < maxSpeed && alive == true)
        {
            spaceshipSpeed += 0.001f;
        }

        HudText();


    }


    public void HudText()
    {
        
        
        //segundos que pasan 
        float tiempo = Time.time;

        //metros recorridos
        dist = Mathf.Round(tiempo) * spaceshipSpeed;
        
        distText.text = Mathf.Round(dist) + "m";



        //nivel dependiendo de dist
        if(dist > 800)
        {
            levelGame = 1;
        }else if(dist > 1400)
        {
            levelGame = 2;
        }else if(dist > 2000)
        {
            levelGame = 3;
        }else if(dist > 2600)
        {
            levelGame = 4;
        }

        levelText.text = levelGame.ToString();


        //el target se calcula con las colisiones - se pone un contador desde 0 y va sumando cada vez que la nav choca con un prefab de basura (?)

        //score es dist + (target * 2)

    }

    

    //Morirse
    public void Morir()
    {
        shipParent.SetActive(false);

        alive = false;
        spaceshipSpeed = 0f;

        gameOver.SetActive(true);


    }
}
