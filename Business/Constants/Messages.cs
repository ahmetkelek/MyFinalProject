using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün eklenemez";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserRegistered="Kullanici kayıt oldu";
        public static string UserNotFound="Kullanıcı bulunamadi";
        public static string PasswordError="Şifre hatalı.";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Bu isimde kullanıcı var zaten.";
        public static string AccessTokenCreated="Access token oluşturuldu";
    }
}
