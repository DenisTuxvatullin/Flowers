using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio2 : MonoBehaviour {
    public AudioSource audio;
	// Use this for initialization
    public static bool muze;
    void Start()
    {
        if (muze == false)
        {
            audio.Play();
            muze = true;
        }
        else { audio.Stop(); }
    }
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    void Update()
    {
        if (!audio.isPlaying)
        {
            audio.Play();


        }

    }
}

