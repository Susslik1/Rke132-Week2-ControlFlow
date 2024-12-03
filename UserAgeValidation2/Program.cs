// See https://aka.ms/new-console-template for more information


//rakendus küsib kasutaja sistada tema vanuse
//kui kasutaja vanus on v'iksem kui 13, siis konsoolis kavatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your Age:");
int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap 13 - stack

if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else //if (userAge < 13)
{
    Console.WriteLine("You are too young to use Instagram");
}