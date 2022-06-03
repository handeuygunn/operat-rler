internal class Program
{
    private static void Main(string[] args)
    {
        int x = 3;
        int y = 3;
        y = y+2;
        Console.WriteLine(y);
        y += 2;
        Console.WriteLine(y);
        y /= 1;
        Console.WriteLine(y);
        x *= 2;
        Console.WriteLine(x);
        bool inSuccess = true;
        bool inComleted = false;
        
        if(inSuccess && inComleted)
        Console.WriteLine("Perfect");

        if(inSuccess || inComleted)
        Console.WriteLine("Great");

        if(inSuccess && !inComleted)
        Console.WriteLine("Fine");

        int a = 3;
        int b = 4;

        bool sonuc = a<b;

        Console.WriteLine(sonuc);
        sonuc = a>b;
        Console.WriteLine(sonuc);
        sonuc = a>=b;
        Console.WriteLine(sonuc);
        sonuc = a<=b;
        Console.WriteLine(sonuc);
        sonuc = a==b;
        Console.WriteLine(sonuc);
        sonuc = a!=b;
        Console.WriteLine(sonuc);

        int sayı1 = 10;
        int sayı2 = 5;
        int sonuc1 = sayı1/sayı2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayı1*sayı2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayı1++;
        Console.WriteLine(sonuc1);
        sonuc1 = sayı2 - sayı1;
        Console.WriteLine(sonuc1);

        int sonuc2 = 200%3;
        Console.WriteLine(sonuc2);





    }
}