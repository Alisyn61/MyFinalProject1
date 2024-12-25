using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static  class Messages
    {

        public static string ProductAdded = "ürün eklendi";

        public static string ProductNameInvalid = "ürün ismi geçersiz";
        public static string MaintenanceTime= "sistem bakımda ";
        public static string ProductsListed= "ürünler listelendi";
        public static string ProductCountOfCategoryError="kategorideki Ürün listesi 15ten büyük olamaz";
        public static string ProductNameAlreadyExist="ürün ismi zaten mevcut";
        public static string CategoryLimitExceded="kategori limiti aşıldığı için eklenemiyor";
        public static string? AuthorizationDenied="yetkiniz yok";
        public static string UserRegistered="kullanıcı kayıt oldu";
        public static string UserNotFound="kullanıcı bulunamadı";
        public static string PasswordError="parola hatası";
        public static string SuccessfulLogin="başarılı giriş";
        public static string UserAlreadyExists="kullanıcı zaten mevcut";
        public static string AccessTokenCreated="giriş tokeni oluştuurldu";
        public static string ProductUpdated = "ürün güncellendi";
    }
}
