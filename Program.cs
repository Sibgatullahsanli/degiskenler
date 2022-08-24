internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        /* 
        int değer = 2;
        string değişken = null;
        //string değişken = null;          --> aynı kod bloğu içerisinde değişken birden fazla defa tanmlanamaz
        string Değişken = null;
         //int 3değişken = null;            --> değişkenlerin başına rakam getirilemez
        //string class= "";                --> özel isim verilemeceğinin denemesi
        //string değiişken+Veri = null;    --> işlem operatörü içeremez ve arada boşlukta kullanılamaz  
                                         //bir değişken ismi kullanmak istersen alt tire kullanabilirsin.                                                

        */
        Console.WriteLine("");



        byte b = 5;        //1 byte (bellekte 1 byt yer kaplar) 0 ile 255 arası değer alabilir
        sbyte c = 5;       //1 sbyte -128 ile 127 arası değer alabilir

        short s = 5;      //2 byte -32768 den 32768 e kadar tam sayı değer alabiliyorlar
        ushort us = 5;    //2 byt yer kaplar 0 dan 65365

        int i16 = 2;    //2 byt 
        int i = 2;        //4 byt
        int i32 = 2;    //4 byt
        long i64 = 2;     //8 byt

        uint ui = 2;      //4 byt
        long l = 4;       //8 byt
        ulong ul = 4;      //8 byt eksi değer alamayıp long kadar değer alıyor

        //Reel sayılar  
        float f = 5;      //4 byt
        double d = 5;     //8 byt
        decimal de = 5;   //16 byt

        char ch = '2';                  //2 byte
        string str = "sıbgatullah";    //sınırsız

        bool b1 = true;
        bool b2 = false;

        DateTime dt = DateTime.Now;

        Console.WriteLine(dt);

        object o1 = "x";
        object o2 = 'y';
        object o3 = 4;
        object o4 = 4.3;

        //string ifadeler

        //string str1 = "";     // BÖYLE OLUR VEYA 
        //string str1 = null;   // BÖYLE YAPILABİLİR VEYA
        string str1 = string.Empty;
        str1 = "sıbgatullah şanlı";
        string ad = "sıbgatullah";
        string soyad = "şanlı";
        string tamisim = ad + " " + soyad;

        //integer tanımlama şekilleri

        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 * integer2;

        // boolen ifadeler

        bool bool1 = 10 < 2; // foase gelece ama eyer > işreti koysaydık true gelir

        // Değişken Dönüşümleri
        string str20 = "20";    // -->
        int int20 = 20;        //  -->  BU İKİ İFADEYİ STRİNG OLARAK BİRLEŞTİRMEK İSTESEM ALTTAKİ UYGULANIR
        string yeniDeğer = str20 + int20.ToString();
        Console.WriteLine(yeniDeğer); // Çıktısı 2020

        // İnteger Dönüşümler
        int int21 = int20 + Convert.ToInt32(str20);
        Console.WriteLine(int21);     // Çıktısı 40

        int int22 = int20 + int.Parse(str20);  //Parse çevirim(parse dönüşümü kast etti galiba) Çıktısı 40

        // datetime

        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);
        string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
        Console.WriteLine(datetime2);
        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);
    }
}
