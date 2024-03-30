namespace Belbin_level
{
    public class User
    {
        protected User()
        {
        }

        public User(Role activeRole, Role passiveRole)
        {
            ActiveRole = activeRole;
            PassiveRole = passiveRole;
        }

        public Role ActiveRole { get; protected set; }

        public Role PassiveRole { get; protected set; }
    }
}