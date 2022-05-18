public class Ex14{
    public void Answer(){
        List<int> numbers1 = new List<int>();
        List<double> numbers2 = new List<double>();

        Console.Clear();

        int num = 0, num2 = 0;
        do{
            Console.Write("Type a list of numbers (0 to exit): ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num != 0){
                numbers1.Add(num);
            }

        }while(num != 0);

        Console.Write('\n');

        do{
            Console.Write("Type another list of numbers: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            numbers2.Add(num2);

        }while(numbers1.Count() > numbers2.Count());

        for(int i = 0; i <numbers1.Count(); i++){
            Console.WriteLine($"Product: {numbers1[i] * numbers2[i]}");
        }
    }
}