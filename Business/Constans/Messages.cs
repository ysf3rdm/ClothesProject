using Core.Entities.Concrete;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public class Messages
    {
        public static string ClothesAdded = "Kıyafet Eklendi";
        public static string ClothesDeleted = "Kıyafet Silindi";
        public static string ClothesUpdated = "Kıyafet Güncellendi";
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string SizeAdded = "Beden Eklendi";
        public static string SizeDeleted = "Beden Silindi";
        public static string SizeUpdated = "Beden Güncellendi";
        public static string CategoryAdded = "Kategori Eklendi";
        public static string CategoryDeleted ="Kategori Silindi";
        public static string CategoryUpdated="Kategori Güncellendi";

        public static string AuthorizationDenied="Yetkisiz Deneme";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatası";
        public static string SuccessfulLogin = "Giriş Yapıldı";
        public static string UserRegistered = "Kaydınız Yapıldı";
        public static string UserAlreadyExists = "Kullanıcı Zaten Var";
        public static string AccessTokenCreated;
        
    }
}
