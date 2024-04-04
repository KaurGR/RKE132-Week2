/*
Application asks user gender (M/F)
Application asks for name
Application greets user "Welcome, [Mr./Ms.] (name)!"
*/

Console.WriteLine("Input your gender (M/F):");
char userGender = Char.Parse(Console.ReadLine()); //single char saved as string
Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();

if (userGender == 'M')
{
    Console.WriteLine($"Welcome, Mr. {name}");
}
else if (userGender == 'F')
{
    Console.WriteLine($"Welcome, Mr. {name}");
}
else
{
    Console.WriteLine($"Hello, {name}");
}