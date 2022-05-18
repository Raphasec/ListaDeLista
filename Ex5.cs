public class Ex5{
    public void Answer(){
        List<char> name = new List<char>(){'R', 'a', 'p', 'h', 'a', 'e', 'l'};
        
        Console.Clear();
        string.Concat(name);
        Console.WriteLine($"{String.Join("", name)}");
    }
}