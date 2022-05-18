public class Ex12{
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

        Console.WriteLine($"The names on the list that ends with O are: ");

        foreach (string names in name)
            {
                if (names.ToLower().EndsWith("o"))
                {
                    Console.Write($"{names}, ");
                }
            }
    }
}
