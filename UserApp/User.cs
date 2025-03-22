using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp
{
   public  class User
    {
        private string adSoyad;
        private int yas;

        public string eMail { get; set; }

       public string Adsoyad {
            
            get{ return adSoyad; }
            set { adSoyad = value; } }
       
        public int Yas
        {
            get { return yas; }

            set { yas = value; }

        }

        public void BilgileriGoster()
        {

            Console.WriteLine("Kullanıcının adı ve soyadı: "+Adsoyad);
            Console.WriteLine("Kullanıcının yaşı: "+Yas);
            Console.WriteLine("Kullanıcının email adresi: "+eMail);


        }

    }
}
