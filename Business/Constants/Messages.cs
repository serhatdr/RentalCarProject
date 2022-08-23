using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Ürün eklendi";
        public static string CarNameInValid = "Geçersiz isim";
        public static string MaintenanceTime="Sistem bakımda";
        public static string CarsListed="Arabalar Listelendi";

        public static string RentalAdded="Kiralama Bilgileri Eklendi";
        public static string RentalDeleted="Kiralama Bilgileri Silindi";
        public static string RentalUpdated = "Kiralama Bilgileri Güncellendi";
        public static string RentalGotByRentId ="Kiralama Bilgisi Id'ye göre getirildi.";
        public static string AllRentalsGot = "Tüm Kiralama Bilgileri Listelendi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string AllCustomersGot = "Tüm Müşteriler Listelendi";
        public static string CustomersGotByCity = "Müşteriler Şehirlere Göre Listelendi";
        internal static string CustomerGotByUserId = "Müşteriler Kullanıcı Id'sine göre listelendi";
        internal static string CustomersGotByContactName = "Müşteriler İsme Göre Listelendi";
        internal static string CustomersGotByCompanyName = "Müşteriler Şirket ismine Göre Listelendi";
        internal static string CustomerUpdated = "Müşteriler Güncellendi";
    }
}
