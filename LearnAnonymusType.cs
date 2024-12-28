
using System.Linq.Expressions;

namespace ControlConsole
{
    public class Entity
    {
        public string Delegasyon1 { get; set; }
        public string Delegasyon2 { get; set; }
    }
    public class LearnAnonymousType : Entity
    {
        public void LearnAnonymousTypeMain()
        {

            ActionParametrs((x, y) =>
            {
                Console.WriteLine($"{x} ve {y} Action Olduğu İçin Bir Geri Dönüşü Yoktur " +
                    $"Ancak Metod İçerisinde Verilen Değerler Yakalanabilir (ActionParametrs)");

            });
            Console.WriteLine(FuncParametrs((x, y) =>
            {
                x = "Anonim Fonksiyon Yoluyla Delegeli Method";
                y = "[1. Yöntemdir]";
                return $"{x} ve {y} (FuncParametrs)";
            }));
            Func<string, string, string> FuncDelegateMethod = (x, y) =>
            {
                x = "Function Dönüş Tiple Oluşturulan Delege Method";
                y = "[2. Yöntemdir]";
                return $"{x} ve {y} (FuncParametrs)";
            };
            Console.WriteLine(FuncParametrs(FuncDelegateMethod));

            Console.WriteLine(FuncMethodReturn("1.Parametreye Giden String Değer",
                "2.Parametreye Giden String Değer")("1.Anonymous Parametr", "2.Anonymous Parametr (FuncMethodReturn)"));

            Console.WriteLine(FuncAnonymousReturn("1.Anonymous Metoda Giden",
                "Ekstra Parantez Açmamıza Gerek Yoktur Delegeye Uygun Bir Metod Şeklinde Üretilir, 2.Anonymous Metoda Giden (FuncAnonymousReturn)"));
        }
        public string FuncParametrs(Func<string, string, string> FuncParametrs)
        {
            return FuncParametrs("1.String Parametresi", "2.String Parametresi => Dönüş Tipimiz String");
        }
        public Func<string, string, string> FuncAnonymousReturn = (x, y) =>
        {
            return $"{x} Burada Anonim Bir [Metod Oluşturduğumuz İçin Doğrudan Delege Edilebilmektedir] {y}";
        };
        public Func<string, string, string> FuncMethodReturn(string firstParametrs, string secondParametrs)
        {
            Console.WriteLine($"{firstParametrs} {secondParametrs} Parametreye String Değerler Ulaştı (FuncMethodReturn)");
            return (x, y) =>
            {
                Console.WriteLine($"Eğer Ki " +
                    $"Function Delege Tipinde Dönmek İstiyorsak Bir Parantez Daha Açarak Anonymous Fonksiyonu Uyandırırız. (FuncMethodReturn)");
                return $"{x} Dönüş tipimiz bir [Delege] ve Delegeye Uygun Şekilde Bir [Metod] oluşturduk. {y}";
            };
        }
        public Action<string, string> ActionAnonymousReturn = (x, y) =>
        {
            Console.WriteLine($"{x} Action Anonymous Delegate Metod [Bir Delegate Metod " +
                $"olduğu için bir Fonksiyonla Desteklemek zorunda Değiliz.] {y}");
        };
        public Action<string, string> ActionMethodReturn(string a, string b)
        {
            return (x, y) =>
            {
                Console.WriteLine($"{a} Burada Bir [Action Dönüş Tipinde Metodumuza Uygun Bir Anonymous Metod Tasarladık] {b}");
            };
        }
        public void ActionParametrs(Action<string, string> ActionParametrs)
        {
            ActionParametrs("1.Action Parametresi", "2.Action Parametresi");
        }
    }
    public class ExpressionProduct
    {
        public int ProductId { get; set; }
        public string ProductFullName { get; set; } = string.Empty;
    }

}

