public class Ex8{
    public void Answer(){
        List<int> list = new List<int>(){8, 9, 6, 3, 7, 2, 5, 4, 1, 2, 7, 8, 5, 9, 4, 2, 3};

        Console.Clear();
        Console.WriteLine($"The numbers of the list are: {string.Join(' ', list)}");

        list.RemoveAll(i => i % 2 == 0);

        Console.WriteLine($"Now, the numbers of the list are: {string.Join(' ', list)}");
    }
}
