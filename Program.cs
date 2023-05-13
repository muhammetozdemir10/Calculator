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

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Hesap makineme hos geldiniz.");
            Console.ResetColor();

            Console.WriteLine("Lutfen yapmak istediginiz islemi seciniz");
            Console.WriteLine("Secebileginiz islemler: (+, -, *, /)");
            string? sign = Console.ReadLine();

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

            // TODO: Kullaniciya baska bir islem yapmak istiyorsa kodu birdaha calistirmayi dene
            // TODO: Kullanici sayi yerine harf girerse hatali bir mesaj versin ve bir kez daha girmesini istesin yada bastan islemi alsin.

        }

    }

}