#region
// This file contains the list of possible violations in program.
#endregion

namespace SecurityLog.Models
{
    public enum ViolationCategory
    {
        None = 0,

        // İçerik ve İletişim İhlalleri
        Spamming = 1,              // Aşırı/tekrarlayan veri veya mesaj gönderimi
        ExplicitContent = 2,       // NSFW, cinsel veya gore görsel/metin paylaşımı
        HateSpeech = 3,            // Nefret söylemi, ırkçılık, ayrımcılık
        Harassment = 4,            // Taciz, şahsa yönelik sistemli rahatsızlık
        Impersonation = 5,         // Başka bir kullanıcının/yetkilinin kimliğine bürünme

        // Güvenlik ve Teknik İhlaller
        Exploitation = 6,          // Sistem açığını/bug'ları kötüye kullanma (Exploit)
        MaliciousPayload = 7,      // Zararlı link, dosya veya script paylaşımı
        RateLimitExceeded = 8,     // İstek/request sınırını kasıtlı aşma gayreti

        // Otomasyon ve Hesap İhlalleri
        AutomationAbuse = 9,       // Yetkisiz bot, macro veya script kullanımı
        MultiAccounting = 10,      // Ban/limit bypass etmek için çoklu hesap kullanımı
        CredentialStuffing = 11    // Sızdırılmış şifre/hesap deneme botculuğu
    }
}