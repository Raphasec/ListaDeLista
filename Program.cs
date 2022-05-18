int op, repeat;

do{
    Console.Clear();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("\tExercise List!");
    Console.WriteLine("-----------------------------------");
    Console.Write("\nType the number of the exercise you want to see (1-15): ");
    op = Convert.ToInt32(Console.ReadLine());
    repeat = 0;
    switch (op){
        case 1:
            Ex1 ex1 = new Ex1();
            ex1.Answer();
            break;
        case 2:
            Ex2 ex2 = new Ex2();
            ex2.Answer();
            break;
        case 3: 
            Ex3 ex3 = new Ex3();
            ex3.Answer();
            break;
        case 4:
            Ex4 ex4 = new Ex4();
            ex4.Answer(); 
            break;
        case 5:
            Ex5 ex5 = new Ex5();
            ex5.Answer();
            break;
        case 6:
            Ex6 ex6 = new Ex6();
            ex6.Answer();
            break;
        case 7:
            Ex7 ex7 = new Ex7();
            ex7.Answer();
            break;
        case 8:
            Ex8 ex8 = new Ex8();
            ex8.Answer();
            break;
        case 9:
            Ex9 ex9 = new Ex9();
            ex9.Answer();
            break;
        case 10:
            Ex10 ex10 = new Ex10();
            ex10.Answer();
            break;
        case 11:
            Ex11 ex11 = new Ex11();
            ex11.Answer();
            break;
        case 12:
            Ex12 ex12 = new Ex12();
            ex12.Answer();
            break;
        case 13:
            Ex13 ex13 = new Ex13();
            ex13.Answer();
            break;
        case 14:
            Ex14 ex14 = new Ex14();
            ex14.Answer();
            break;
        case 15:
            Ex15 ex15 = new Ex15();
            ex15.Answer();
            break;
        default:
            Console.WriteLine("ERROR!!! Press any key to continue");
            repeat = 1;
            Console.ReadKey();
            break;
    }   
}while (repeat != 0);
