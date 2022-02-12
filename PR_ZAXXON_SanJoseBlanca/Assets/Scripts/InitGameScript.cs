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

    //audio
    [SerializeField] AudioSource audioImpact;
    [SerializeField] AudioSource audioBoton; 

    //estado
    public bool alive;


    //Explosión
    [SerializeField] Transform shipPos;
    [SerializeField] GameObject explosionPrefab;


    /*------------------UI----------------------*/

    [SerializeField] Text distText;
    [SerializeField] Text levelText;
    [SerializeField] Text targetText;
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject damage;
    [SerializeField] GameObject warning;

    //vidas
    [SerializeField] Image lives;
    [SerializeField] Sprite[] livesArray;

    [SerializeField] int vidas;
    int spritesPos = 0;

    //target
    
    int contadorTarget;

    //score
    [SerializeField] Text scoreText;
    float score;

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

        vidas = 3;
        lives.sprite = livesArray[spritesPos];

        gameOver.SetActive(false);
        damage.SetActive(false);
        warning.SetActive(false);

        contadorTarget = 0;

        score = 0;

        

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
        float tiempo = Time.timeSinceLevelLoad;

        //metros recorridos 
        if (spaceshipSpeed != 0)
        {
            dist = Mathf.Round(tiempo) * spaceshipSpeed;
        }
        
        
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


        //score segun distancia y objetivos 
        score = Mathf.Round(dist) + (contadorTarget * 37);

        scoreText.text = score.ToString(); 

        

    }



    //Objetos
    public void Target()
    {
        contadorTarget++;
        targetText.text = contadorTarget.ToString();

    }

    //Chocarse
    public void Chocar()
    {
        vidas--;
        spritesPos++;
        lives.sprite = livesArray[spritesPos];
        gameOver.SetActive(false);
        damage.SetActive(true);
        warning.SetActive(true);
        audioImpact.Play();

        if (vidas == 0)
        {
            Morir();
        }

        

    }

    //Morirse
    public void Morir()
    {
        

        alive = false;
        spaceshipSpeed = 0f;

        //Explosion en la posicion de la nave
        
        Vector3 exploPos = new Vector3(shipPos.position.x, shipPos.position.y, shipPos.position.z);
        Instantiate(explosionPrefab, exploPos, Quaternion.identity);

        damage.SetActive(true);

        Invoke("GameOver", 1.5f);

        

    }

    void GameOver()
    {

        gameOver.SetActive(true);
                
        shipParent.SetActive(false);

    }



}
