//rakendus küsib kasutajalt vanust
//kui kasutaja vanus on väiksem kui 13, siis kuvatakse
//"You are too young to use instagram"
//muul juhul
//Konsoolis kuvatakse "Welcome to instagram"


Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;
//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

//int userAge = Int32.Parse(Console.ReadLine());

Console.WriteLine($" Parse result {isAgeNumber}. User is {userAgeNum} years old."); ;

if (isAgeNumber)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to instagram");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}




//if (userAge >= 13)
//{
//    Console.WriteLine("Welcome to Instagram");
//}
//else
//{
//    Console.WriteLine("You are too young to use Instagram.");
//}
