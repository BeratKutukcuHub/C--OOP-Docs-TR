
namespace ControlConsole
{
    public class LearnTuple
    {
        List<(int firstNum, int SecondNum)> Calculation { get; set; } = new();
        public (int Topla, int Carp) TupleMethod((int firstNum, int firstSec) item)
        {
            return (item.firstNum + item.firstSec, item.firstNum * item.firstSec);
        }
        public void LearnTupleMain()
        {
            var tupleDeğişken = (Name: "Berat", LastName: 23, IsActive: false ? "Evet" : "Hayır");
            var (toplam, carpim) = TupleMethod((20, 20));

            Calculation.Add((toplam, carpim));
            Console.WriteLine($"Toplanan Değerler : {toplam} Carpılan Değerler : {carpim}");
            Console.WriteLine($"İsminiz : {tupleDeğişken.Name} " +
                $"Soyisminiz : {tupleDeğişken.LastName} Active : {tupleDeğişken.IsActive}");
            foreach (var item in Calculation)
            {
                Console.WriteLine($"Toplananlar {item.firstNum}, Çarpılanlar {item.SecondNum}");
            }
        }
    }
}
