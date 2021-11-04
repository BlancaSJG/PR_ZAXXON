using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIlives : MonoBehaviour
{
    [SerializeField] Image lives;
    [SerializeField] Sprite[] livesArray;
 
    [SerializeField] int vidas;
    int spritesPos = 0;

    // Start is called before the first frame update
    void Start()
    {
        vidas = 3;
        lives.sprite = livesArray[spritesPos];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Chocar();
            print("chocaste");
        }

    }

    public void Chocar()
    {
        vidas--;
        spritesPos++;
        lives.sprite = livesArray[spritesPos];

    }

}
