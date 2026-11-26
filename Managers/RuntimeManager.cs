#region
// This file manages the algorithm flow on runtime
#endregion

using SecurityLog.Models;
using SecurityLog.UI;

namespace SecurityLog.Managers
{
    public static class RuntimeManager
    {
        public static void Begin()
        {
            var user = new User();
            var (username, password) = LoginMenu.Show();
            user.Name = username;
            user.Password = password;
        }
    }
}
