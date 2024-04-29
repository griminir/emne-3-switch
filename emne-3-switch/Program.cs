// See https://aka.ms/new-console-template for more information
Console.WriteLine("switch");

//oppgave 1
int num = 7;

void run()
{
    switch (num)
    {
        case 1:
            Console.WriteLine("it's Monday");
            break;
        case 2:
            Console.WriteLine("it's Tuesday");
            break;
        case 3:
            Console.WriteLine("IT'S WENDSDAY MY DUDES");
            break;
        case 4:
            Console.WriteLine("it's Thursday");
            break;
        case 5:
            Console.WriteLine("it's Friday");
            break;
        case 6:
            Console.WriteLine("it's Saturday");
            break;
        case 7:
            Console.WriteLine("it's Sunday");
            break;
                
    }
}
run();

//oppgave 2
void run1()
{
    Console.WriteLine("give me a number");
    var isThisNumber = Console.ReadLine();

    // this lets us check if it's an int the _ can be replaced with a variabel that stores the value if true
    bool wasItaNumber = int.TryParse(isThisNumber, out _); 


    switch (wasItaNumber)
    {
        case true:
            Console.WriteLine("good");
            break;
        case false:
            Console.WriteLine("nope");
            run1();
            break;

    }
}
run1();