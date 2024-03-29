using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMusicManage : MonoBehaviour
{
    [SerializeField] AudioSource BackGroundMusic;

    private bool isEnadle = true;
    public void Update()
    {
        if (isEnadle)
        {
            BackGroundMusic.enabled = true;
        }
        else
            BackGroundMusic.enabled = false;
    }
    public void EnableMusic()
    {
        if (isEnadle)
        {
            isEnadle = false;
        }
        else
            isEnadle = true;
    }
}
