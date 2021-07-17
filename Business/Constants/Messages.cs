using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba başarıyla eklendi.";
        public static string CarDeleted = "Araba başarıyla silindi.";
        public static string CarUpdated = "Araba başarıyla güncellendi.";
        public static string NameInvalid = "Girilen isim geçersiz.";
        public static string PriceInvalid = "Girilen araba fiyatı geçersiz.";

        public static string BrandAdded = "Marka başarıyla eklendi.";
        public static string BrandDeleted = "Marka başarıyla silindi.";
        public static string BrandUpdated = "Marka başarıyla güncellendi.";

        public static string ColorAdded = "Renk başarıyla eklendi.";
        public static string ColorDeleted = "Renk başarıyla silindi.";
        public static string ColorUpdate = "Renk başarıyla güncellendi.";

        public static string CustomerAdded = "Müşteri başarıyla eklendi.";
        public static string CustomerDeleted = "Müşteri başarıyla silindi.";
        public static string CustomerUpdated = "Müşteri başarıyla bilgileri güncellendi.";

        public static string RentalAdded = "Kiralama bilgisi başarıyla eklendi.";
        public static string RentalDeleted = "Kiralama bilgisi başarıyla silindi.";
        public static string RentalUpdated = "Kiralama bilgisi başarıyla güncellendi.";

        public static string UserAdded = "Üye başarıyla eklendi.";
        public static string UserDeleted = "Üye başarıyla silindi.";
        public static string UserUpdated = "Üye başarıyla güncellendi.";

        public static string CarImageAdded = "Araba resmi başarıyla eklendi!";
        public static string CarImageDeleted = "Araba resmi başarıyla silindi";
        public static string CarImageUpdated = "Araba resmi başarıyla güncellendi!";
        public static string ImageLimitExceded = "Bir arabanın en fazla 5 resmi olabilir!";

        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt olundu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatalı.";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
    }
}
