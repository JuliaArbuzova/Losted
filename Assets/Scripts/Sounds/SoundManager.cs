using UnityEngine;

public class SoundManager : MonoBehaviour
{
  public AudioSource soundPlay;

  public void PlayThisSound()
  {
    soundPlay.Play();
  }
}