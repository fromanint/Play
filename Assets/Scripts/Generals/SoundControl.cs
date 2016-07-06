using UnityEngine;
using System.Collections;

public class SoundControl : MonoBehaviour {

    public void StopAudio() {
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        foreach (AudioSource audio in audios)
        {
            audio.Stop();
        }
    }

    public void PlayAudio() {
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        foreach (AudioSource audio in audios)
        {
            audio.Play();
        }
    }
}
