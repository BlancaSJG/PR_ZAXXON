using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Transform playerPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //La camara sigue a la nave con una distancia en el eje Z
        transform.position = new Vector3(playerPosition.position.x, playerPosition.position.y, playerPosition.position.z - 4);
    }
}

