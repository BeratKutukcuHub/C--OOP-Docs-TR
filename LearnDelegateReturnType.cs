using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConsole
{
    
        public class LearnDelegateReturnType
        {
        
        public void LearnDelegateReturnTypeMain()
        {
            Calculator calculator = new();
            calculator.CalculatorMain("Fatih Terim", 56, Parametrs.Divide);
        }
        public enum Parametrs
        {
            Divide,
            Impact,
            Increment,
            Extraction
        }
        public class Calculator
        {
            public delegate string CalculatorDelegater(Func<string, int, string> func);
            CalculatorDelegater CalculatorDelegatered;
            public string Calculated(Func<string,int, string> cal)
            {
                return $"{cal("", 0)}";
            }
            public void CalculatorMain(string a, int b, Parametrs flag) 
            {
                CalculatorDelegatered = Calculated;
                Console.WriteLine(CalculatorDelegatered((x, y) =>
                {
                    return $"Age : {a} ve {b} Adlı Şahıs.";
                }));
                
            }
            private Func<int ,int, int> Increment (int a , int b) 
            {
                return (x, y) =>
                {
                    x = a;
                    y = b;
                    return x + y;
                };
            }
            private Func<int, int, int> Extraction (int a, int b)
            {
                return (x, y) =>
                {
                    x = a;
                    y = b;
                    return x - y;
                };
            }
            private Func<int, int, int> Impact (int a, int b)
            {
                return (x, y) =>
                {
                    x = a;
                    y = b;
                    return x * y;
                };
            }
            private Func<int, int, int> Divide (int a, int b)
            {
                return (x, y) =>
                {
                    x = a;
                    y = b;
                    return x / y;
                };
            }
            private string ProblemsReturn(Func<int, int, int> func)
            {
                var item = func(0, 0);
                return $"Elde Edilecek Değer : [{item}] Olacaktır.";
            }
            
        }

}
    
}
