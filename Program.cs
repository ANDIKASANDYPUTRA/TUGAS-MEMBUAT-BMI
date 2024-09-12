using System;

class Program
{
    static void Main()
    {
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.Write("Masukkan berat badan (kg): ");
            double berat = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan tinggi badan (m): ");
            double tinggi = Convert.ToDouble(Console.ReadLine());

            double bmi = berat / (tinggi * tinggi);
            Console.WriteLine($"BMI Anda adalah: {bmi:F2}");

            if (bmi < 18.5)
                Console.WriteLine("Kekurangan berat badan");
            else if (bmi < 24.9)
                Console.WriteLine("Berat badan normal");
            else if (bmi < 29.9)
                Console.WriteLine("Kelebihan berat badan");
            else
                Console.WriteLine("Kegemukan");

            Console.Write("Apakah Anda ingin menghitung lagi? (y/n): ");
            string input = Console.ReadLine().ToLower();

            if (input != "y")
                continueRunning = false;
        }

        Console.WriteLine("Terima kasih telah menggunakan kalkulator BMI.");
    }
}