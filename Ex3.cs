public class Ex3{
    public void Answer(){
        int i;
        List<double> numbers = new List<double>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        List<double> square = new List<double>();
        
        for(i = 0; i < numbers.Count(); i++){
            square.Add(Math.Pow(numbers[i], 2));
        }
        Console.Clear();
        Console.WriteLine($"The numbers of the first list are: {String.Join(' ', numbers)}");
        Console.WriteLine($"The numbers of the second list are: {String.Join(' ', square)}");
    }
}