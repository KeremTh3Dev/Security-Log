#region
// This file contains methods belonging to the user
#endregion

using SecurityLog.Helpers;
using SecurityLog.Models;
using SecurityLog.UI;

namespace Actions
{
    public static class UserMethods
    {
        public static User RegisterUser()
        {
            var user = new User();
            var (username, password) = LoginMenu.Show();
            user.Name = username;
            user.Password = password;
            return user;
        }

        //index is the decision on violationcategory
        public static void DecideViolation(User user)
        {
            int index = Input.GetInt32();
            user.Violated = (ViolationCategory)index;
        }

        public static void RegisterViolation(User user)
        {
            if (user.Violated == ViolationCategory.None)
                return;
            user.ViolationsLog.Record(user.Violated);
        }
    }
}
