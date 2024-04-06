using UnityEngine;
using UnityEngine.SceneManagement;

namespace End
{
    public class EndController : MonoBehaviour
    {
        private void Update()
        {
            PlayerPrefs.SetInt("Scene", 0);
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) SceneManager.LoadScene(0);
        }
    }
}