using System;

namespace Belbin_level
{
    public class Gamer : User
    {
        private bool _hasActiveRole;
        public event Action OnFirstRole;
        public event Action OnSecondRole;

        public void SetRole(Role role)
        {
            if (!_hasActiveRole)
            {
                _hasActiveRole = true;
                ActiveRole = role;
                OnFirstRole?.Invoke();
            }
            else
            {
                PassiveRole = role;
                OnSecondRole?.Invoke();
            }
        }
    }
}