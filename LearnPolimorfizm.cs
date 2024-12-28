using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConsole
{
    public interface IClassTesting
    {
        public ClassTesting View(string param);
    }
    public class ClassTesting : IClassTesting
    {
        public ClassTesting()
        {

        }
        public ClassTesting(string A)
        {
            ConsoleMethod(A);
        }
        public void ConsoleMethod(string A)
        {
            Console.WriteLine(A);
        }
        public ClassTesting View(string A)
        {
            return new ClassTesting(A);

        }
    }
    public class LearnPolimorfizm : ClassTesting 
    {
        public void LearnPolimorfizmMain()
        {
            ReturnedMethod("Burada Bir Polimorfizm Vardır, Bir Class Yapısına Method ile Geri Dönüş Sağladık");
            ReturnedMethod("Sebebi İse Methodun Aslında Bir Class'ın Instance'sini Oluştururarak Geri Dönmesidir.");
        }
        
        public IClassTesting ReturnedMethod(string A)
        {
            return View(A);
        }
        
    }
    
}
