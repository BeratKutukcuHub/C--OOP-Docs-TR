using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ControlConsole
{
    public class LearnExtension : ControllerBase
    {

        public IControllerBase LearnExtensionMain(int key, string value)
        {
            var item = new { first = value, second = key, third = true };

            return this.ErrorController($"{item.first} {item.second} {item.third}");
        }

    }
    public static class ControllerExtensions
    {
        public static IControllerBase ErrorController(this IControllerBase controller, object A)
        {
            return new ControllerBase(A.ToString());
        }
    }
    public interface IControllerBase
    {
        IControllerBase ViewBase(string A);
    }
    public class ControllerBase : IControllerBase
    {
        List<string> Values { get; set; } = new()
        {
            "Sebaahat",
            "Furkan",
            "Alperen",
            "Burçin"
        };
        public string ListItemsGetOutHere()
        {
            int x = 0;
            if (x < Values.Count)
            {
                string y = string.Empty;
                for (int i = 0; i <= Values.Count - 1; i++)
                {
                    x += i;
                    y = Values[i];
                }
                ListItemsGetOutHere();
                return y;
            }
            else return "Liste Bitti";
        }
        private string ErrorMessage { get; set; } = string.Empty;
        public ControllerBase() { }
        public ControllerBase(string A)
        {
            Console.WriteLine(A);
        }
        public IControllerBase ErrorController(string ErrorOrResult)
        {
            return new ControllerBase(ErrorOrResult);
        }
        public IControllerBase ViewBase(string A)
        {
            if (A is null)
            {
                if (A.Length <= 3)
                {
                    ErrorMessage = $"{A} => Geçersiz. 3 haneden büyük değerler giriniz.";
                    return ErrorController(ErrorMessage);
                }
                ErrorMessage = $"{A} => Geçersiz. Boş değer verilmiştir.";
                return ErrorController(ErrorMessage);
            }
            return ErrorController(A);
        }
    }
}
