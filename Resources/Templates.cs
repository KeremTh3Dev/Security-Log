#region
// This file contains screen templates
#endregion

using SecurityLog.Models;

namespace SecurityLog.Resources
{
    public static class Templates
    {
        public const string Login = @"
╔══════════════════════════════════════════════╗
║              KULLANICI GİRİŞİ                ║
╠══════════════════════════════════════════════╣
║                                              ║
║  Kullanıcı Adı :                             ║
║  Şifre         :                             ║
║                                              ║
╚══════════════════════════════════════════════╝
";
        public static string Violations = @$"
================================================================================
   SECURITYLOG // ABUSE SIMULATION & VIOLATION DISPATCHER
================================================================================

  [ CONTENT & COMMUNICATION ]
    [{(int)ViolationCategory.Spamming,2}]  Spamming             -> Flood / repetitive message or payload spam
    [{(int)ViolationCategory.ExplicitContent,2}]  ExplicitContent      -> NSFW, sexual, or graphic/gore material
    [{(int)ViolationCategory.HateSpeech,2}]  HateSpeech           -> Racism, discrimination, or hate rhetoric
    [{(int)ViolationCategory.Harassment,2}]  Harassment           -> Targeted abuse or repeated intimidation
    [{(int)ViolationCategory.Impersonation,2}]  Impersonation        -> Spoofing another user or staff identity

  [ SECURITY & TECHNICAL ]
    [{(int)ViolationCategory.Exploitation,2}]  Exploitation         -> Abusing system bugs, glitches, or flaws
    [{(int)ViolationCategory.MaliciousPayload,2}]  MaliciousPayload     -> Harmful links, files, or script injection
    [{(int)ViolationCategory.RateLimitExceeded,2}]  RateLimitExceeded    -> Deliberately hammering request limits

  [ AUTOMATION & ACCOUNT ]
    [{(int)ViolationCategory.AutomationAbuse,2}]  AutomationAbuse      -> Unauthorized bots, macros, or scripts
    [{(int)ViolationCategory.MultiAccounting,2}]  MultiAccounting      -> Alt accounts to bypass bans or limits
    [{(int)ViolationCategory.CredentialStuffing,2}]  CredentialStuffing   -> Leaked credential / brute-force stuffing

================================================================================
   [0] Exit / Cancel Simulation || MAKE A DECISION BETWEEN INDEXES.
================================================================================
"; // 1'den 11'e kadar seçim yaptırırız
    }
}