using System;
using UnityEngine;

namespace Belbin_level
{
    public class RoleButton : MonoBehaviour
    {
        [SerializeField] private Role _role;
        public event Action<Role> OnChosen;

        public void Choose()
        {
            OnChosen?.Invoke(_role);
            gameObject.SetActive(false);
        }
    }
}