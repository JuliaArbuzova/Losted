using System;
using UnityEngine;

namespace Belbin_level
{
  public class PersonButton : MonoBehaviour
  {
    [SerializeField] private GameObject _text;
    [SerializeField] private Role _firstRole;
    [SerializeField] private Role _secondRole;

    public event Action<GameObject, Role, Role> OnPressed;

    public void ChoosePerson()
    {
      OnPressed?.Invoke(_text, _firstRole, _secondRole);
      gameObject.SetActive(false);
    }
  }
}