using UnityEngine;

public class BackMusicManage : MonoBehaviour
{
    [SerializeField] private AudioSource BackGroundMusic;

    private bool isEnadle;

    private void Start()
    {
        isEnadle = PlayerPrefs.GetInt("Sound") == 1;
    }

    public void Update()
    {
        if (isEnadle)
            BackGroundMusic.enabled = true;
        else
            BackGroundMusic.enabled = false;
    }

    public void EnableMusic()
    {
        if (isEnadle)
        {
            isEnadle = false;
            PlayerPrefs.SetInt("Sound", 0);
        }
        else
        {
            isEnadle = true;
            PlayerPrefs.SetInt("Sound", 1);
        }
    }
}