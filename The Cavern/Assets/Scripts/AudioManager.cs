﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource BGM;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        if (FindObjectsOfType<AudioManager>().Length > 1)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeBGM (AudioClip music)
    {
        if (BGM.clip.name == music.name)
        {
            return;
        }

        if (music.name == "Nivel4-6")
        {
            BGM.volume = 0.1f;
        }
        else
        {
            BGM.volume = 0.9f;
        }

        BGM.Stop();
        BGM.clip = music;

        if (!Globals.stopMusic)
        {
            BGM.Play();
        }
    }
}
