using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1 
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("3 dene eded daxil edin");
            //    string a = Console.ReadLine();
            //    string b = Console.ReadLine();
            //    string c = Console.ReadLine();

            //    try
            //    {
            //        int aa = int.Parse(a);
            //        int bb = int.Parse(b);
            //       int cc = int.Parse(c);
            //        Muqayise(aa, bb, cc);

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Duzgun deyer daxil edin");

            //    }
            //    catch (OverflowException)
            //    {
            //       Console.WriteLine("Duzgun deyer daxil et");
            //    }

            //    Muqayise(45, 78, 90);
            //    Muqayise(45, 78, 78);



            //}
            //static void Muqayise(int a, int b, int c)
            //{
            //    if(a != b && a != c && b != c)
            //    {
            //        if(a > b && a > c)
            //        {
            //            Console.WriteLine("En boyuk eded: " + a);
            //        }
            //        else if(b > a && b > c)
            //        {
            //            Console.WriteLine("En boyuk eded: " + b);
            //        }
            //        else if(c > a && c > b)
            //        {
            //            Console.WriteLine("En boyuk eded: " + c);
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Bir-birine beraber ededler daxil etmeyin");
            //    }
            //}
            #endregion

            #region Task2 
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("5 dene eded daxil edin");
            //    string a = Console.ReadLine();
            //    string b = Console.ReadLine();
            //    string c = Console.ReadLine();
            //    string d = Console.ReadLine();
            //    string e = Console.ReadLine();

            //    try
            //    {
            //        int aa = int.Parse(a);
            //        int bb = int.Parse(b);
            //        int cc = int.Parse(c);
            //        int dd = int.Parse(d);
            //        int ee = int.Parse(e);
            //        Average(aa, bb, cc, dd, ee);

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Duzgun deyer daxil edin");


            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Duzgun deyer daxil edin");
            //    }
            //    Average(45, 78, 90, 54, 78);

            //}

            //static void Average(int a, int b, int c, int d, int e)
            //{
            //    int result = 0;
            //    if (a > 0 && b > 0 && c > 0 && d > 0 && e > 0)
            //    {
            //        result = (a + b + c + d + e) / 5;
            //        Console.WriteLine("Ededi orta: " + result);


            //    }
            //    else
            //    {
            //        Console.WriteLine("Natural ededler daxil edin");
            //    }
            //}

            #endregion

            #region Task3
            // static void Main(string[] args)
            //{
            //    Console.WriteLine("Duzbucaqlinin sahe ve perimetr ucun 2 dene eded daxil edin");
            //    string a = Console.ReadLine();
            //    string b = Console.ReadLine();

            //    try
            //    {
            //        uint aa = uint.Parse(a);
            //        uint bb = uint.Parse(b);
            //        SahePerimetr(aa, bb);
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Duzgun deyer daxil edin");


            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Duzgun deyer daxil et");
            //    }

            //    SahePerimetr(78, 90);
            //}

            //static void SahePerimetr(uint a, uint b)
            //{

            //    uint sahe = 0;
            //    uint perimetr = 0;


            //    if (a != b && a > 0 && b > 0) 
            //    {
            //        sahe = a * b;
            //        perimetr = 2 * (a + b);
            //        Console.WriteLine($"Sahe: {sahe} ve Perimetr: {perimetr}");


            //    }
            //    else
            //    {
            //        Console.WriteLine("Bir-birine beraber olmayan natural ededler daxil edin");

            //    }
            //}

            #endregion

            #region Task4
            // static void Main(string[] args)
            //{
            //    Console.WriteLine("Eded daxil edin");
            //    string a = Console.ReadLine();

            //    try
            //    {
            //        int aa = int.Parse(a);
            //        SadeMurekkeb(aa);

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Duzgun deyer daxil edin");


            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Duzgun deyer daxil edin");
            //    }

            //    SadeMurekkeb(90);
            //    SadeMurekkeb(353);

            //}

            //static void SadeMurekkeb(int a)
            //{
            //    if(a > 1)
            //    {
            //        int count = 0;

            //        for (int i = 1; i < a; i++)
            //        {
            //            if (a % i == 0)
            //            {
            //                count++;

            //            }
            //            if(count > 1)
            //            {
            //                Console.WriteLine(a + " Murekkeb ededir ");
            //                break;
            //            }

            //        }
            //        if(count <= 1)
            //        {
            //            Console.WriteLine(a + " Sade ededdir ");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("1-den boyuk ededler daxil edin");
            //    }
            //}


            #endregion

            #region Task5
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Eded daxil edin");
            //    string a = Console.ReadLine();

            //    try
            //    {
            //        int aa = int.Parse(a);
            //        Mertebe(aa);

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Duzgun deyer daxil edin");


            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Duzgun deyer daxil edin");


            //    }
            //    Mertebe(1111);



            //}
            //static void Mertebe(int a)
            //{
            //    int count = 0;
            //    if(a != 0)
            //    {
            //        for (int i = 1; 1 <= a; i++)
            //        {
            //            a = a / 10;
            //            count++;

            //        }
            //        Console.WriteLine("Mertebe sayi: " + count);
            //    }
            //    else
            //    {
            //        Console.WriteLine("0 daxil etmeyin");
            //    }


            //}






            #endregion

            #region Task6
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Eded daxil edin");
            //    string a = Console.ReadLine();

            //    try
            //    {
            //        int aa = int.Parse(a);
            //        Sum(aa);

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Duzgun deyer daxil edin");


            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Duzgun deyer daxil edin");

            //    }

            //    Sum(90);

            //}

            //static void Sum(int a)
            //{
            //    if(a > 0)
            //    {
            //        if(a % 21 == 0)
            //        {
            //            Console.WriteLine("Daxil edilen eded hem 3-e hem de 7-ye bolunur");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Daxil edilen eded hem 3-e hem de 7-ye bolunmur");

            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Natural eded daxil edin");
            //    }
            //}

            #endregion

            #region Task7 
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Imtahan balini daxil edin");
            //    string a = Console.ReadLine();

            //    try
            //    {
            //        byte aa = byte.Parse(a);
            //        ExamResult(aa);

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Duzgun deyer daxil edin");


            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Duzgun deyer daxil edin");

            //    }

            //    ExamResult(100);

            //}

            //static void ExamResult(byte a)
            //{
            //    if(a >= 0 && a <= 100)
            //    {
            //        if(a <=100 && a >= 91)
            //        {
            //            Console.WriteLine("A");
            //        }
            //        else if(a >= 81 && a <= 90)
            //        {
            //            Console.WriteLine("B");

            //        }
            //        else if(a >= 71 && a <= 80)
            //        {
            //            Console.WriteLine("C");

            //        }
            //        else if(a >= 61 && a <= 70)
            //        {
            //            Console.WriteLine("D");

            //        }
            //        else if(a >= 51 && a <= 60)
            //        {
            //            Console.WriteLine("E");

            //        }
            //        else
            //        {
            //            Console.WriteLine("Kesildiniz");

            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("1-den 100-e qeder ededler daxil edin");
            //    }
            //}



            #endregion

            #region Task8
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("2 dene eded daxil edin");
            //    string a = Console.ReadLine();
            //    string b = Console.ReadLine();

            //    try
            //    {
            //        int aa = int.Parse(a);
            //        int bb = int.Parse(b);
            //        ResultBetweenTwoNumbers(aa, bb);

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Duzgun deyer daxil edin");


            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Duzgun deyer daxil edin");

            //    }
            //    ResultBetweenTwoNumbers(67, 1000);
            //    ResultBetweenTwoNumbers(90, 0);


            //}

            //static void ResultBetweenTwoNumbers(int a, int b)
            //{
            //    int max = 0;
            //    int min = 0;
            //    int sum = 0;
            //    if(a > b)
            //    {
            //        max = a;
            //        min = b;


            //    }
            //    else if(a < b)
            //    {
            //        max = b;
            //        min = a;

            //    }
            //    else
            //    {
            //        Console.WriteLine("Beraber ededler daxil etmeyin");
            //    }

            //    while(min <= max)
            //    {
            //        sum += min;
            //        min++;

            //    }
            //    Console.WriteLine(sum);
            //}



            #endregion

            #region Task9
            // static void Main(string[] args)
            //{
            //    Console.WriteLine("2 dene eded daxil edin");
            //    string n = Console.ReadLine();
            //    string m = Console.ReadLine();

            //    try
            //    {
            //        int nn = int.Parse(n);
            //        int mm = int.Parse(m);
            //        Quvvet(nn, mm);

            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Duzgun deyer daxil et");


            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Duzgun deyer daxil et");
            //    }

            //}

            //static void Quvvet(int n, int m)
            //{
            //    int i = 1;
            //    int result = 1;
            //    if(n > 1 && m > 1)
            //    {
            //        while(i <= n)
            //        {
            //            result = result * m;
            //            i++;
            //        }
            //        Console.WriteLine(result);

            //    }
            //    else
            //    {
            //        Console.WriteLine("1-den boyuk ededler daxil edin");
            //    }

            //}

            #endregion
























        }
    }
}
