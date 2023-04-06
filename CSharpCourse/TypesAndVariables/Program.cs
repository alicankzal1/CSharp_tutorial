// See https://aka.ms/new-console-template for more information
//integer veri tipi 32 bittir. Yaklaşık +- 2 milyara kadar sayıyı tutabilir.(-2147483648       +2147483647)

int num1 = 111111;
Console.WriteLine("num1 is : {0}", num1); // {0} index gösterimi diyebiliriz.


// long veri tipi integer veri tipinin tutamadığı değerleri tutar. Yaklaşık 19 basamağa kadar sayı yazılabilir. 64 bit'tir. İnteger veri tipinden daha fazla yer tutar.
long num2 = 1234567890123456789;
Console.WriteLine("num2 is : {0}", num2);

// short veri tipi -32768 ile +32767 değerleri arasındaki değerleri tutabilir. 16 bittir az yer tutar.
short num3 = 32767;
Console.WriteLine("num3 is : {0}", num3);

// byte 0'la 255 arasında değer tutar.
byte num4 = 255;
Console.WriteLine("num4 is : {0}", num4);

// bool (true veya false)
bool condition = true;
Console.WriteLine("condition is : {0} ", condition);

//char klavyemizde bastığımız heerhangi bir karakterin veri tipi diyebiliriz. '' kullanmamız lazım.
//bir harfin ASCII karşılığını char veri tipiyle öğrenebiliriz.Eğer char değişkeninin isminin başına (int) yazarsak bunu öğrenmiş oluruz.
char character = 'A';
Console.WriteLine("char is : {0}", character);
Console.WriteLine("char'ın sayısal karşılığı : {0}", (int)character);

// double : tam sayılardan farklı olarak ondalıklı sayıları tutabiliriz. 64 bitlik yer tutar.

double num5 = 10.4;
Console.WriteLine("num5 is : {0}", num5);

//decimal : double değerinin daha hassas hesaplamaları için kullanılır.
//double virgülden sonra 15-16 değer tutabiliyorken decimal ise 28-29 tane değer tutabilir. Yazdığımız değerin sonuna m harfi eklemeliyiz.

decimal num6 = 10.3472398410948109248m;
Console.WriteLine("num6 is : {0}", num6);

//C# enum veri tipi, bir programda belirli bir önceden tanımlanmış değer kümesini temsil etmek için kullanılan bir yapıdır.
//Bu değerler, bir sayısal değer veya metinsel bir değerle eşleştirilebilir ve programcıya bu değerleri adlandırmalarına ve daha anlamlı hale getirmelerine olanak tanır.

//Örneğin, bir programcı bir oyun yazarken oyuncunun karakter sınıfını seçmesine izin vermek isteyebilir.
//Bunun için enum yapısını kullanabilir ve sınıfları aşağıdaki gibi tanımlayabilir:
// (int) metoduyla index değerler erişilebilir.

KarakterSiniflari secilenSinif = KarakterSiniflari.Buyucu;


Console.WriteLine("Seçilen sınıf: " + secilenSinif);
Console.WriteLine((int)KarakterSiniflari.Buyucu);

    

// var keywordü ile değerler otomatik belirlenir.
var num7 = 322;
Console.WriteLine("num7 is : {0}", num7);
Console.ReadLine();


enum KarakterSiniflari
{
    Savasci,
    Buyucu,
    Suikastci,
    Paladin

}