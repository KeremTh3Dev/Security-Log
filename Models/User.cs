#region
// This file contains data about user
#endregion

namespace SecurityLog.Models
{
    public class User
    {
        public string? Name {get; set;}
        public string? Password {get; set;}
        public ViolationCategory Violated {get; set;}
        public UserViolationsLog ViolationsLog { get; } = new();
    }
}