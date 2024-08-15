using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="AudioM", menuName ="ScriptableObjects/AudioManager")]
public class Audio : ScriptableObject
{
    public AudioClip jump;
    public AudioClip slide;

    public void SlidingAudio(AudioSource audioSource)
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            audioSource.PlayOneShot(slide);
        }

    }
}
