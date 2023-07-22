using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopAmbient : MonoBehaviour
{
    public AudioSource ambient;
    public AudioSource headMusic;

    public AudioSource music;



    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "shadow" && ambient.isPlaying)
        {
            ambient.Pause();
        }

        if (collider.gameObject.name == "shadow" && headMusic.isPlaying)
        {
            headMusic.Pause();
        }

        if (collider.gameObject.name == "shadow" && !music.isPlaying)
        {
            Invoke("playMusic", 4.0f); //to delay playing the music 4s
        }

    }

    void playMusic()
    {
        music.Play();

    }
}