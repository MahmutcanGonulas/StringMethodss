using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken="Dersimiz CSharp, Hosgeldiniz!";
            string degisken2="Dersimiz CSharp";
            string degisken3="dersimiz CSharp";
            string degisken4="CSharp";

            //Length = karakter sayisi;
            Console.WriteLine(degisken.Length);

            //toUpper = Tüm karakterleri büyüt
            //toLower = Tüm karakterleri küçük
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat = Sona birleştime yaptı
            Console.WriteLine(String.Concat(degisken," Merhaba!"));

            //Compare, CompareTo
            //Birinci degisken ikinci değişkene eşitse 0
            //Birinci degisken ikinci değişkenden büyükse 1
            //Birinci degisken ikinci değişkene küçükse -1
            Console.WriteLine(degisken.CompareTo(degisken2));
            //büyük küçük harf duyasız hale gelir true olursa
            //false ta duyarlı
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken2,degisken3,false));

            //contains
            Console.WriteLine(degisken.Contains(degisken4));

            //EndWith StartWith
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf = C'nin indexini döner
            //bulamazsa -1 döner
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Zzz"));

            //Insert
            //0'dan başla Merhaba ekle
            Console.WriteLine(degisken.Insert(0,"Merhaba! "));
            //sondaki i'nin indexi gelir
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Padleft, PadRight
            //degisken2'nin sonuna 30 tamamlyacak kadar boşluk eklenir(degisken 2'nin karakterleri dahil)
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));

            //Remove
            //10. indexten sona kadar sil
            Console.WriteLine(degisken.Remove(10));
            //5. karakteren başla 3 karakter sil
            Console.WriteLine(degisken.Remove(5,3));

            //Replace
            //CSharp C# olarka değişir
            //Boşluklar * olur
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split = parçala
            //parçala ve 1.'yi getir
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            //4. indexten sona kadar getir
            Console.WriteLine(degisken.Substring(4));
            //4. indexten başla 6 karakter getir
            Console.WriteLine(degisken.Substring(4,6));
            





            
        }
    }
}