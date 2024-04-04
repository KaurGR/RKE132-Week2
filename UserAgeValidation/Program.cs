/*
Application asks user age
if (age<13) output "grow up" 
else if (age>13) output "welcome to our application"
*/

Console.WriteLine("Enter your age:");
//int age = Int32.Parse(Console.ReadLine());

string age = Console.ReadLine();
int ageNum = 0;

bool isAgeNum = Int32.TryParse(age, out ageNum);

if (isAgeNum)
{
    if (ageNum < 13)
    {
        Console.WriteLine("Grow up!");
    }
    else // if(age >= 13)
    {
        Console.WriteLine("welcome to our application");
    }
}
else
{
    Console.WriteLine("Enter numbers");
}