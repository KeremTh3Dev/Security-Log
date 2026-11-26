#region 
// This file includes helper methods for console procceses.
#endregion

using SecurityLog.Resources;

namespace SecurityLog.Helpers
{
    public static class Input
    {
        public static string GetStr()
        {
            return Console.ReadLine()??"";
        }
        public static int GetInt32()
        {
            while (true)
            {
                string? input = Console.ReadLine();

                if(int.TryParse(input, out int result))
                {
                    return result;
                }
                
                Log.Info(ErrorMessage.InvalidInt32);
            }
        }
    }
}