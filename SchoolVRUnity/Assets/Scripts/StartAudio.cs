using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAudio : MonoBehaviour {
    public AudioClip impact;
    public List<AudioSource> musics;
    AudioSource audio;
    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        //transform.position += new Vector3(0f,1f,0f);
        bool play = false;
        foreach(AudioSource source in musics)
        {
            if (source.isPlaying)
            {
                play = true;
            }
        }
        if (!play)
        {
            audio.clip = impact;
            audio.Play();
        }
    }
}
