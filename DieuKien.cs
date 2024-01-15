using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;


class DieuKien
{

    // Hàm kiểm tra số chẵn
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    //InBangCuuChuong
    static void InBangCuuChuong()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Bang cuu chuong thu {i}");

            for (int j = 0; j <= 10; j++)
            {
                int ketQua = i * j;
                Console.WriteLine($"{i} * {j} = {ketQua}");
            }
            Console.WriteLine();
        }
    }

    //KiemTraSoNguyenTo
    static void PrimeCheck(int n = 100)
    {
        for (int i = 2; i <= n; i++)
        {
            bool number = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    number = false;
                    break;
                }
                if (number)
                {
                    Console.WriteLine($"{j}la so nguyen to");
                }
                else
                {
                    Console.WriteLine($"{j} khong phai là số nguyen to");
                }
            }
        }
    }
    //TínhGiaiThừa

    static long factorialCaculator(int number)
    {
        if (number < 0)
        {
           // throw new ArgumentException("Số nhập vào phải là số nguyên dương.");
            Console.WriteLine($"{number} khong phai so nguyen duong");
            return -1;
        }
        if (number == 0 || number == 1)
        {
            return 1; //trả về giá trị 1 luôn
        }
        long factorial = 1;
        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    static void EvenTotal(int number)
    {
        int sum = 0;
        for (int i = 0; i < number; i++)
        {
            if (IsEven(i))
            {
                sum += i;
            }
        }
        Console.WriteLine($"Tong các sỗ chẵn từ 0 đến {number} là: {sum}");

    }

    static void Draw()
    {
        Console.WriteLine("Nhập số dòng muôn vẽ tam giác");
        string DrawTri = Console.ReadLine();

        if (int.TryParse(DrawTri, out int line))

            for (int i = 1; i <= line; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();

            }

    }

   static string StrToBinary(string str)
    {
        StringBuilder binaryStringBuilder = new StringBuilder();

        foreach (char character in str)
        {
            // Chuyển mỗi ký tự thành biểu diễn nhị phân và thêm vào chuỗi nhị phân
            binaryStringBuilder.Append(Convert.ToString(character, 2).PadLeft(8, '0'));
        }

        return binaryStringBuilder.ToString();
    }

    static void Main()
    {
        Console.Write("Nhập một số nguyên: ");
        string InputNumber = Console.ReadLine();
        // int number = Convert.ToInt32(Console.ReadLine());

        /* int.TryParse(InputNumber, out int number);
         if (IsEven(number)) */

        if (int.TryParse(InputNumber, out int number))
        {
            if (IsEven(number))
            {
                Console.WriteLine($"{number} là số chẵn.");
            }
            else
            {
                Console.WriteLine($"{number} không phải là số chẵn.");
            }

        }
        else
        {
            Console.WriteLine("Khong phai so nguyen");
        }

        InBangCuuChuong();
        PrimeCheck();


        long factorialNumber = factorialCaculator(number);
            Console.WriteLine($"{number}! co giai thua la {factorialNumber}");


        EvenTotal(number);
        Draw();

        string inputString = "algoritm"; // Chuỗi đầu vào tùy ý

        string binaryResult = StrToBinary(inputString);

        Console.WriteLine($"Biểu diễn nhị phân của chuỗi '{inputString}' là: {binaryResult}");
    }



}