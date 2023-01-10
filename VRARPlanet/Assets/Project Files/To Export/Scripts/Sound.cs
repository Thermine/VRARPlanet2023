using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;

    public float volume = 1f;

    [HideInInspector]
    public AudioSource source;
    
}
