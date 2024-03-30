using UnityEngine;

namespace Main_Menu
{
    public class ManagerOfButton : MonoBehaviour
    {
        [SerializeField] private GameObject _musicOn;
        [SerializeField] private GameObject _musicOff;

        private void Start()
        {
            if (PlayerPrefs.GetInt("Sound") == 1)
            {
                _musicOn.SetActive(true);
                _musicOff.SetActive(false);
            }
            else
            {
                _musicOn.SetActive(false);
                _musicOff.SetActive(true);
            }
        }
    }
}