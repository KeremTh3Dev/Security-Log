#region
// This file contains methods to control console screen
#endregion

namespace SecurityLog.UI
{
    public static class Screen
    {
        public static void New(string layoutString)
        {
            Console.Clear();
            Console.WriteLine(layoutString);
        }
    }
}
