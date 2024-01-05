using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarsListed = "Arabalar listelendi";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandsListed = "Markalar listelendi";

        public static string ColorAdded = "Renkler eklendi";
        public static string ColorDeleted = "Renkler silindi";
        public static string ColorUpdated = "Renkler güncellendi";
        public static string ColorsListed = "Renkler listelendi";

        public static string RentalAdded = "Kiralama işlemi gerçekleşti";
        public static string RentalDeleted = "Kiralama işlemi  silindi";
        public static string RentalUpdated = "Kiralama işlemi güncellendi";
        public static string RentalsListed = "Kiralamalar listelendi";
        public static string TheCarHasNotBeenReturnedYet = "Araç henüz teslim edilmedi";
        public static string ThePriceMustBeGreaterThanZero = "Fiyat 0'dan yüksek olmalı";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomersListed = "Müşteriler listelendi";  
        
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UsersListed = "Kullanıcılar listelendi";

        public static string ConflictsWithMaintenanceTime = "Aracın bakım zamanı ile çakışıyor.";
    }
}