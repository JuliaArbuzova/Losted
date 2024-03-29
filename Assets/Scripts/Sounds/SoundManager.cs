using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource soundPlay;

    public void PlayThisSound()
    {
        soundPlay.Play();
    }
}
