public class Ex2{
    public void Answer(){
        Console.Clear();

        List<int> numbers = new List<int>{15, 26, 38, 97, 2};
        numbers.Sort();
        numbers.Reverse();

        Console.WriteLine($"The numbers of the list, in the reverse order, are: {String.Join(' ', numbers)}");
    }
}