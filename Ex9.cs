public class Ex9{
    public void Answer(){
        int i = 0;
        List<int> list = new List<int>(){8, 9, 6, 3, 7, 2, 5, 4, 1, 2, 7, 8, 5, 9, 4, 2, 3};

        foreach(int element in list){
            if(element == 2){
                i++;
            }
        }

        Console.Clear();
        Console.WriteLine($"O número 2 parece {i} vezes");
    }
}
