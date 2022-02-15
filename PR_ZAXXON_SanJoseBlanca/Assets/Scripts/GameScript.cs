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
    
    [SerializeField] Slider volumeSlider;
    

    [SerializeField] AudioMixer masterMixer;

    private void Start()
    {

    }



    public void SetSfxLvl(float sfxVol)
    {

        masterMixer.SetFloat("sfxVol", sfxVol);


    }

    public void SetMusicLvl(float musicVol)
    {
        masterMixer.SetFloat("musicVol", musicVol);

        
  

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
