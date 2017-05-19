using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusiqueTrigger : MonoBehaviour {

    public AudioClip impact;
    AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();

    }

    public void PlayMusic()
    {
        //transform.position += new Vector3(0f,1f,0f);
        audio.clip = impact;
        audio.Play();


    }
}
