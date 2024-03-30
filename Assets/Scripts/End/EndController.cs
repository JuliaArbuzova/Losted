using UnityEngine;
using UnityEngine.SceneManagement;

namespace End
{
    public class EndController : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetMouseButtonDown(0)) SceneManager.LoadScene(0);
        }
    }
}