using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameScript : MonoBehaviour
{

    //audio
    [SerializeField] AudioSource audioBoton;
    [SerializeField] AudioClip clipbtn;
    int escenacarga;
    
    [SerializeField] Slider sfxSlider;
    [SerializeField] Slider musicSlider;



    [SerializeField] AudioMixer masterMixer;

    private void Start()
    {
        sfxSlider.value = GameManager.sfxVolumen;
        musicSlider.value = GameManager.musicVolumen;


    }



    public void SetSfxLvl(float sfxVol)
    {

        masterMixer.SetFloat("sfxVol", sfxVol);
        //GameManager.sfxVolumen = sfxVol;
        PlayerPrefs.SetFloat("sfxVol", sfxVol);
        GameManager.sfxVolumen = PlayerPrefs.GetFloat("sfxVol");

    }

    public void SetMusicLvl(float musicVol)
    {
        masterMixer.SetFloat("musicVol", musicVol);

        PlayerPrefs.SetFloat("musicVol", musicVol);
        GameManager.musicVolumen = PlayerPrefs.GetFloat("musicVol");


    }

    

    

    public void CargarEscena(int escena)
    {
        audioBoton.PlayOneShot(clipbtn);

        Invoke("CargarEscena2", clipbtn.length);
        
        
        //SceneManager.LoadScene(escena);
        audioBoton.Play();
        escenacarga = escena;

    }


    void CargarEscena2()
    {
        SceneManager.LoadScene(escenacarga);
    }
}
