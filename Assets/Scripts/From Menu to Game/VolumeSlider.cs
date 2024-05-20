using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class VolumeSlider : MonoBehaviour
{
    
    
    
    public AudioMixer mixer;
    
    public Slider sfxSlider;
    public Slider musicSlider;
    


    void Start()
    {
        
        if (PlayerPrefs.HasKey("SFXVolume"))
        {
            mixer.SetFloat("SFXVolume", PlayerPrefs.GetFloat("SFXVolume"));
        }

        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            mixer.SetFloat("MusicVolume", PlayerPrefs.GetFloat("MusicVolume"));
        }

        else
        {
            SetSliders();
        }

        
    }

    
    void Update()
    {
        
    }

    public void SetSliders()
    {
        sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
    }

    public void UpdateSFXVolume()
    {
        mixer.SetFloat("SFXVolume", Mathf.Log10(sfxSlider.value)*20);
        PlayerPrefs.SetFloat("SFXVolume", sfxSlider.value);
    }
    
    public void UpdateMusicVolume()
    {
        mixer.SetFloat("MusicVolume", Mathf.Log10(musicSlider.value) * 20);
        PlayerPrefs.SetFloat("MusicVolume", musicSlider.value);
    }
}
