// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

;

//static void Degiskenler()
//{
//    string mesaj = "Merhaba";
//    double tutar = 100000;//db den gelir
//    int sayi = 100;
//    bool girisYapmisMi = false;

//    string ad = "Engin";
//    string soyad = "Demiroğ";
//    int dogumYili = 1985;
//    long tcNo = 12345678910;


//    Console.WriteLine(tutar * 1.18);
//    Console.WriteLine(tutar * 1.18);
//}

Vatandas vatandas = new Vatandas();


//pascal casing
SelamVer(isim: "Engin");
SelamVer(isim: "Diana");
SelamVer(isim: "Emir");
SelamVer();

int sonuc = Topla(3, 5);

static void SelamVer(string isim = "isimsiz")
{

    Console.WriteLine("Merhaba" + " " + isim);
}




static int Topla(int sayi1, int sayi2)
{
    int sonuc = sayi1 + sayi2;

    Console.WriteLine("Toplam: " + sonuc);
    return sonuc;
}


public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}
