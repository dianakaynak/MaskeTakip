// See https://aka.ms/new-console-template for more information
using Entities.Concrete;

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

int sonuc = Topla(6,58);

//Diziler /Arrays

string ogrenci1 = "Engin";
string ogrenci2 = "Kerem";
string ogrenci3 = "Berkay";

//Console.WriteLine(ogrenci1);
//Console.WriteLine(ogrenci2);
//Console.WriteLine(ogrenci3);


string[] ogrenciler = new string[3];

ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";

ogrenciler= new string[4];
ogrenciler[3] = "İlker";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);

}


string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Person person1= new Person();
person1.FirstName = "Engin";

Person person2 = new Person();
person2.FirstName = "Murat";

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> { "Ankara 1 ", "İstanbul 1","İzmir 1 "};
yeniSehirler1.Add(item: "Adana 1 ");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}





static void SelamVer(string isim = "isimsiz")
{

    Console.WriteLine("Merhaba" + " " + isim);
}




static int Topla(int sayi1=5, int sayi2=10)
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
