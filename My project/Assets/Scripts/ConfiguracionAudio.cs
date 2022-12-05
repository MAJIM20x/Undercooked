using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfiguracionAudio : MonoBehaviour
{
    
    private static readonly string musicaFondoPref = "MusicaFondoPref";
    private static readonly string efectoSonidoPref = "EfectoSonidoPref ";             
    private float musicaFondoFloat, efectoSonidoFloat;
    public AudioSource musicaFondoAudio;
    public AudioSource[] efectoSonidoAudio;


    void Awake()
    {
       continueSettings();
    }



    public void continueSettings()
    {
        musicaFondoFloat = PlayerPrefs.GetFloat(musicaFondoPref);
        efectoSonidoFloat = PlayerPrefs.GetFloat(efectoSonidoPref);

        musicaFondoAudio.volume = musicaFondoFloat; 

        for(int i = 0; i < efectoSonidoAudio.Length; i++)
        {
            efectoSonidoAudio[i].volume = efectoSonidoFloat;
        }





    }
}

