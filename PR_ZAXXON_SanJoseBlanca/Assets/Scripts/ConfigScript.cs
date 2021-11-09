using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConfigScript : MonoBehaviour
{

    [SerializeField] Slider volumeSlider;


    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = GameManager.volumeMusic;
    }

    public void CambiarVolumenMusica()
    {
        GameManager.volumeMusic = volumeSlider.value;

    }

    public void CargarEscena(int escena)
    {
        SceneManager.LoadScene(escena);

    }

}
