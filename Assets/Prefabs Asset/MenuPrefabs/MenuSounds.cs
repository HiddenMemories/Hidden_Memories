﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class MenuSounds : MonoBehaviour
{

    public AudioSource click;
    public AudioSource thunderClick;
   

    public Animation IntroSoundRain;
    
    
    public Animation fadesoundThunder;

    public void Awake()
    {
        IntroSoundRain.Play("RainSoundFadeIn");
        
        
    }
    public void clickPlay()
    {
        click.Play();
    }
    public void thunderPlay()
    {
        thunderClick.Play();
        fadesoundThunder.Play("ThunderSoundFadeOut");
       
      

    }
}
