public class Ex7{
    public void Answer(){
        List<string> list1 = new List<string>(){"E", "es", "progr", "usa", "lis"};
        List<string> list2 = new List<string>(){"u", "tou", "amando", "ndo", "tas"};
        List<string> list3 = new List<string>();

        for (int i = 0; i < list1.Count(); i++){
            list3.Add(list1[i] + list2[i]);
        }

        Console.Clear();
        Console.WriteLine($"{String.Join(' ', list3)}");
    }
}
