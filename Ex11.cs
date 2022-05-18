public class Ex11{
    public void Answer(){
        List<string> name = new List<string>();
        string word = "exit";
        
        Console.Clear();
        do{
            Console.WriteLine("Type any name: (exit to close)");
            word = Console.ReadLine();
            Console.WriteLine("\n");

            if(word != "exit"){
                name.Add(word);
            }
        }while(word != "exit");

        name.Sort();

        Console.WriteLine($"The names on the list are: {String.Join(", ", name)}");
    }
}