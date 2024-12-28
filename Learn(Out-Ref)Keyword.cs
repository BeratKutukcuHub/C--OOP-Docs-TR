using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConsole
{
    internal class LearnRefOutKeyword
    {
        public void LearnRefOutKeywordMain()
        {
            string resultOutKeyword = "Ben Out Keywordüyüm.";
            string resultRefKeyword = "Ben Ref Keywordüyüm.";

            var RefandOut = new RefAndOut();
            RefandOut.RefKeywordMain(ref resultRefKeyword);
            RefandOut.OutKeywordMain(out resultOutKeyword);
            Console.WriteLine($"İşleme Tabii Tutulan Ref: {resultRefKeyword}");
            Console.WriteLine($"İşleme Tabii Tutulan Out: {resultOutKeyword}");
        }
    }
    public class RefAndOut
    {
        public void OutKeywordMain(out string Key) 
        {
            Console.WriteLine("Out Keywordü Temel Özellikleri Parametreye gelen Değeri Değitirir.");
            Console.WriteLine("Out Keywordü ile gelen Değer Metotta Değiştirilmek Zorundadır.");
            Console.WriteLine("Out Keywordu ile Parametre Üzerinden Bir Çok Değer Döndürülebilir.");
            Console.WriteLine("Out Keywordü Yerine Tuple Geri Dönüşler Önerilir [Anlaşılabilirlik Açısından]");
            Key = $"Out Keywordü ile Gelen Veri Değiştirilmiştir";
        }
        public void RefKeywordMain(ref string Key)
        {
            Console.WriteLine("Ref Keywordüne Gelen Değişken Dolu Olmalıdır ve Metotta Parametrenin Değerinin Değiştirmeye Gerek Yoktur.");
            Console.WriteLine("Ref Keywordunde Değişken Üzerinde Değişiklikler Yapılabilir");
            Console.WriteLine("-------");
            Key = $"{Key} Ref Keywordü ile Gelen Veri Üzerinde Değişiklik Yapılmıştır";
        }
    }
}
