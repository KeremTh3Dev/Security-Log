#region
// This file contains the initial login screen methods.
#endregion

using SecurityLog.Helpers;
using SecurityLog.Resources;

namespace SecurityLog.UI
{
    public static class LoginMenu
    {
        public static (string Username, string Password) Show()
        {
            Screen.New(Templates.Login);

            Console.CursorVisible = true;

            Console.SetCursorPosition(19, 5);
            string? username = Input.GetStr();

            Console.SetCursorPosition(19, 6);
            string? password = Input.GetStr();

            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 10);

            return (username, password);
        }
    }
}
