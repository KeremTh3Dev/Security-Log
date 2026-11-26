#region
// This file is built to make user select a violation.
#endregion

using SecurityLog.Resources;

namespace SecurityLog.UI
{
    public static class ViolationMenu
    {
        public static void Show()
        {
            Screen.New(Templates.Violations);
        }
    }
}