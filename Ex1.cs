public class Ex1{
    public void Answer(){
        Console.Clear();

        List<int> numbers = new List<int>{15, 26, 38, 97, 2};
        numbers.Sort();

        Console.WriteLine($"The numbers of the list are: {String.Join(' ', numbers)}");
    }
}