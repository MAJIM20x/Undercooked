using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private static readonly string firstPlay = "Firstplay";
    private static readonly string musicaFondoPref = "MusicaFondoPref";
    private static readonly string efectoSonidoPref = "EfectoSonidoPref";
    private int firstPlayInt;
    public Slider musicaFondoSlider, efectoSonidoSlider;
    private float musicaFondoFloat, efectoSonidoFloat;
    public AudioSource musicaFondoAudio;
    public AudioSource[] efectoSonidoAudio;


    void Start()
    { 
        firstPlayInt = PlayerPrefs.GetInt(firstPlay);

        if (firstPlayInt == 0)
        {
           musicaFondoFloat = .25f;
           efectoSonidoFloat = .75f;
           musicaFondoSlider.value = musicaFondoFloat;
           efectoSonidoSlider.value = efectoSonidoFloat;
           PlayerPrefs.SetFloat(musicaFondoPref, musicaFondoFloat); 
           PlayerPrefs.SetFloat(efectoSonidoPref, efectoSonidoFloat);
           PlayerPrefs.SetInt(firstPlay, -1);
                
                
        }
        else
        {
            musicaFondoFloat = PlayerPrefs.GetFloat(musicaFondoPref);
            musicaFondoSlider.value = musicaFondoFloat;
            efectoSonidoFloat = PlayerPrefs.GetFloat(efectoSonidoPref);
            efectoSonidoSlider.value = efectoSonidoFloat;
        }
        
    } 

    public void SaveConfiguracionSonido()
    {
        PlayerPrefs.SetFloat(musicaFondoPref, musicaFondoSlider.value); 
        PlayerPrefs.SetFloat(efectoSonidoPref, efectoSonidoSlider.value);

    }
    
    
    void onApplicationFocus(bool inFocus)
    {
        if (!inFocus)
        {
            SaveConfiguracionSonido();
        } 
    } 


     public void actualizarSonido()
    {
        musicaFondoAudio.volume = musicaFondoSlider.value;
        
        for(int i= 0; i < efectoSonidoAudio.Length; i++)
        {
            efectoSonidoAudio[i].volume = efectoSonidoSlider.value;
        }
    } 

}