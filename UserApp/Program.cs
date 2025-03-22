namespace UserApp
{

    public class Program
    {
        static void Main(string[] args)
        {

            User kullanıcı = new User();

            kullanıcı.Adsoyad = "Erdem Carus";
            kullanıcı.Yas = 25 ;
            kullanıcı.eMail = "erdem@gmail.com";
            kullanıcı.BilgileriGoster();

        }
    }

}
    