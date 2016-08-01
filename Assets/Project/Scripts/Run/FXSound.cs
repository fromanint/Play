using UnityEngine;
using System.Collections;

public class FXSound : MonoBehaviour {
    [SerializeField]
    float Volume;
    [SerializeField]
    AudioClip Sound;

    public void PlaySoundFX(Collider2D other)
    {
            AudioSource player_sound= other.GetComponent<AudioSource>();
            player_sound.clip = Sound;
            player_sound.volume = Volume;
            player_sound.Play();
    }

    public void PlaySoundFX(Collision2D other)
    {
        AudioSource player_sound = other.gameObject.GetComponent<AudioSource>();
        player_sound.clip = Sound;
        player_sound.volume = Volume;
        player_sound.Play();
    }
}

