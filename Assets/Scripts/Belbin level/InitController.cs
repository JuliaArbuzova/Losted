using UnityEngine;

namespace Belbin_level
{
    public class InitController : MonoBehaviour
    {
        [SerializeField] private GameObject _task;
        [SerializeField] private GameObject _levelController;
        private Gamer _gamer;


        private void Start()
        {
            _gamer = new Gamer();
            _gamer.OnFirstRole += ChangeTask;
            _gamer.OnSecondRole += StartLevel;
            foreach (var button in transform.GetComponentsInChildren<RoleButton>()) button.OnChosen += _gamer.SetRole;
        }

        private void ChangeTask()
        {
            _task.transform.GetChild(0).gameObject.SetActive(false);
            _task.transform.GetChild(1).gameObject.SetActive(true);
        }

        private void StartLevel()
        {
            _levelController.SetActive(true);
            _levelController.GetComponent<LevelController>().Init(_gamer);
            _task.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}