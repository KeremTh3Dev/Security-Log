#region
// This file manages the algorithm flow on runtime
#endregion

using Actions;
using SecurityLog.Models;
using SecurityLog.UI;

namespace SecurityLog.Managers
{
    public static class RuntimeManager
    {
        public static void Begin()
        {
            User activeUser = UserMethods.RegisterUser();

            while (true)
            {
                ViolationMenu.Show(); //ekrana seçimleri koyar

                UserMethods.DecideViolation(activeUser); //seçimden seçtirir
                
                UserMethods.RegisterViolation(activeUser); //seçimi kaydettirir
            }

            //seçim yaptırma metodunu koy
        }
    }
}
