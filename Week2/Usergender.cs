//rakendus küsib kasutaja sugu
//rakendus küsib kasutajalt nime
//lähtudes valikust rakendus tervitab kasutajat:
//"Welcome,Mr.[kasutaja perekonnanimi]/"Welcome ms. {kasutaja perekonnanimi]"



Console.WriteLine("Please selest your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("Please enter your last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome,Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}