namespace MusteriTemsilcisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz.İşlem seçiniz: \n1-EFT(1)\n2-Havale(2)\n3-İnternet Bankacılığı(3)\n4-Şifre İşlemleri(4)");
            byte secim = byte.Parse(Console.ReadLine());
            //if (secim == 1)
            //{
            //    Console.WriteLine("EFT İşlemleri");
            //}
            //else if (secim == 2)
            //{
            //    Console.WriteLine("Havale İşlemleri");
            //}
            //else if (secim == 3)
            //{
            //    Console.WriteLine("İnternet Bankacılığı");
            //}
            //else if (secim == 4)
            //{
            //    Console.WriteLine("Şifre İşlemleri");
            //}
            //else
            //{
            //    Console.WriteLine("Operatöre Bağlıyorum...");
            //}
            switch (secim)
            {
                case 1:
                    Console.WriteLine("EFT İşlemleri");
                    break;
                case 2:
                    Console.WriteLine("Havale İşlemleri");
                    break;
                case 3:
                    Console.WriteLine("İnternet Bankacılığı");
                    break;
                case 4:
                    Console.WriteLine("Şifre İşlemleri");
                    break;
                default:
                    Console.WriteLine("Operatöre Bağlıyorum...");
                    break;
            }
        }
    }
}
