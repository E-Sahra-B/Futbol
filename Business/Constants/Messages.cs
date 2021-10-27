using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string TeamAdded="Takım başarıyla eklendi.";
        public static string TeamDeleted = "Takım başarıyla silindi";
        public static string TeamUpdated = "Takım başarıyla güncellendi";
        public static string TeamsListed = "Takımlar listelendi";

        public static string LeagueAdded = "Lig başarıyla eklendi";
        public static string LeagueDeleted = "Lig başarıyla silindi";
        public static string LeagueUpdated = "Lig başarıyla güncellendi";
        public static string LeaguesListed = "Ligler listelendi";

        public static string PlayerAdded = "Futbolcu başarıyla eklendi";
        public static string PlayerDeleted = "Futbolcu başarıyla silindi";
        public static string PlayerUpdated = "Futbolcu başarıyla güncellendi";
        public static string PlayersListed = "Futbolcular listelendi";

        public static string MatchAdded = "Maç karşılaşması başarıyla eklendi";
        public static string MatchDeleted = "Maç karşılaşması başarıyla silindi";
        public static string MatchUpdated = "Maç karşılaşması başarıyla güncellendi";
        public static string MatchesListed = "Maç karşılaşmaları listelendi";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string NameAlreadyExists = "Girmiş olduğunuz veri zaten mevcut";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";

        public static string TeamGetById = "Takım bilgisi getirildi";
    }
}
