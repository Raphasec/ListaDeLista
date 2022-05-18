// Faça um programa que permita ao usuário digitar os nomes e os preços de produtos até que seja digitado "sair" no nome de um produto. Ao fim, 
// o programa deve exibir os produtos (nome e preço) cujo preço esteja acima da média.
// 	Dica: use os métodos Add() e Average() de listas e uma estrutura "do..while"

public class Ex15{
    public void Answer(){
        string word;
        double avg;
        List<string> name = new List<string>();
        List<double> price = new List<double>();

        Console.Clear();

        do{
            Console.Write("Type the name of the products (type 'exit' to quit): ");
            word = Console.ReadLine();
            if(word != "exit"){
                name.Add(word);
                Console.Write("Type the price of the same product: ");
                price.Add(Convert.ToInt32(Console.ReadLine()));
            }
            else{
                break;
            }
        }while(word != "exit");

        avg = price.Average();

        Console.WriteLine("\nProducts with price above average!!!\n");
        Console.Clear();
        for(int i = 0; i < name.Count(); i++){
            if(price[i] > avg){
                Console.WriteLine($"Name: {name[i]}");
                Console.WriteLine($"Price: {price[i]}");
            }
        }
    }
}
