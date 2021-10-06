using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGameScript : MonoBehaviour
{
    //variable velocidad de la nave (del juego)
    public float spaceshipSpeed;

    //variable nivel del juego
    public int levelGame; 
    
    
    // Start is called before the first frame update
    void Start()
    {
        spaceshipSpeed = 10f;
        levelGame = 1;
        

    }

// Update is called once per frame
void Update()
    {
        
    }
}
