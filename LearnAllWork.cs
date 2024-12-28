using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConsole
{
    class CalculatedProblems
    {
        public string MethodReturn { get; set; }
    }
    class CalculatorModel
    {
        public static List<CalculatedProblems> CalculatedProblems = new();
        public CalculatorModel(Calculated calculated)
        {
            var item = Problems(Anonymous(calculated.firstParametr, calculated.secondParametr,
                calculated.FlagCalculators),
                calculated.FlagCalculators);
            Console.WriteLine(item);
            CalculatedProblems.Add(new ControlConsole.CalculatedProblems()
            {
                MethodReturn = item
            });
        }
        Func<int,int,Calculated.FlagCalculator,int> Anonymous = (x, y, flag) =>
        {
            if (Calculated.FlagCalculator.Toplama == flag)
                return x + y;
            else if (Calculated.FlagCalculator.Çıkarma == flag)
                return x - y;
            else if (Calculated.FlagCalculator.Çarpma == flag)
                return x * y;
            else return x / y;
        };
        public string Problems(int func, Calculated.FlagCalculator cal)
        {
            
            return $" => İşleminizin Sonucu : [{func}] , Yapılan İşlem : [{cal}] <=";
        }
    }
    class Calculated
    {
        public int firstParametr { get; set; }
        public int secondParametr { get; set; }
        public enum FlagCalculator 
        {
            Toplama,
            Çıkarma,
            Çarpma,
            Bölme
        } 
        public FlagCalculator FlagCalculators { get; set; }
        
    }
    internal class LearnAllWork 
    {
        Calculated _calculated;

        public LearnAllWork(Calculated calculated)
        {
            _calculated = calculated;
        }

        virtual public void LearnAllWorkMain(int a, int b, Calculated.FlagCalculator c)
        {
            new CalculatorModel(_calculated = new()
            {
                firstParametr = a,
                secondParametr = b,
                FlagCalculators = c
            });
        }
    }
}
