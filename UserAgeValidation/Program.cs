// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Saskia!");

// rakendus küsib kaustajal valida tema sugu (m/n)
// rakendus küsin kasutajalt sisedatda tema perekonnanime
// löhtudes kasjuatja valikust, rakendus tervitab kasutajat jägmiselt:
// "Welcome, Mr. [kasutaja perekonnanimi / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); // loeb konsoolist maha andmeid sting (sõne) formaadis
Console.WriteLine("Please, enrter your name");
string userLastName = Console.ReadLine();

if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if(userGender =='f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}



