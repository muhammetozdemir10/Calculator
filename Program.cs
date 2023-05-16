namespace Calculator
{
    internal class Program
    {

        /*
         * Calculator Projesi
         * Carpma, Bolme, Cikartma, Toplama islemleri icerir.
         * 
         * 
         * 
         */

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Minus(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Div(int a, int b)
        {
            return a / b;
        }

        static void Greeting()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Hesap makineme hos geldiniz.");
            Console.ResetColor();

        }


        static void App()
        {
            Console.WriteLine("Lutfen yapmak istediginiz islemi seciniz");
            Console.WriteLine("Secebileginiz islemler: (+, -, *, /)");
            string? sign = Console.ReadLine();

            try
            {
                Console.WriteLine("Birinci sayiyi giriniz");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ikinci sayiyi giriniz");
                int number2 = int.Parse(Console.ReadLine());

                switch (sign)
                {
                    case "+":
                        Console.WriteLine(Sum(number1, number2));
                        break;

                    case "-":
                        Console.WriteLine(Minus(number1, number2));
                        break;

                    case "*":
                        Console.WriteLine(Multiply(number1, number2));
                        break;

                    case "/":
                        Console.WriteLine(Div(number1, number2));
                        break;

                    default:
                        Console.WriteLine("Gecersiz bir islem girdiniz");
                        break;
                }
            }
            catch (Exception ex)
            {
                //Console.ForegroundColor = ConsoleColor.DarkRed;
                //Console.WriteLine(ex);
                //Console.ResetColor();
                Console.WriteLine("Bir hata olustu lutfen tekrardan deneyiniz.");
                App();
            }

            

            Console.WriteLine("Yapmak isteginiz baska bir islem varmi? Y/N");
            string? Cevap = Console.ReadLine();
            if (Cevap.ToLower() == "y")
            {
                App();
            }
        }


        static void Main(string[] args)
        {
            Greeting();
            App();

            // COMPLETE: Kullaniciya baska bir islem yapmak istiyorsa kodu birdaha calistir
            // COMPLETE: Kullanici sayi yerine harf girerse hatali bir mesaj versin ve bir kez daha girmesini istesin yada bastan islemi alsin.


        }

    }

}