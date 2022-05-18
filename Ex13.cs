public class Ex13{
    public void Answer(){
        List<int> list = new List<int>();
            int value;
            do
            {
                Console.Write("Digite o valor: ");
                string entValue = Console.ReadLine();
                value = int.Parse(entValue);
                if (value != 0) list.Add(value);
            } while (value != 0);

            int sum = list.Sum();
            int max = list.Max();
            int min = list.Min();
            double avg = list.Average();
            int qt = list.Count;

            Console.WriteLine($"A soma é {sum}.");
            Console.WriteLine($"O máximo é {max}.");
            Console.WriteLine($"O mínimo é {min}.");
            Console.WriteLine($"A média é {avg}.");
            Console.WriteLine($"A quantidade é {qt}.");
    }
}