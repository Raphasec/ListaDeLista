public class Ex4{
    public void Answer(){
            int i, sum;
            List<int> numbers1 = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            List<int> numbers2 = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.Clear();
            Console.Write($"The sum of the numbers are: ");
            for(i = 0; i < numbers1.Count(); i++){
                sum = numbers1[i] + numbers2[i];
                Console.Write($"{sum} "); 
            }
    }
}