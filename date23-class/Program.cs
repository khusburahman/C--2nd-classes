

//The cricket World Cup has started in Chefland. There are many teams participating in the group stage matches. Any team that scores 
//12
//12 or more points in the group stage matches qualifies for the next stage.

//You know the score that a particular team has scored in the group stage matches. Determine if the team has qualified for the next stage or not.


int run=Convert.ToInt32(Console.ReadLine());

if (run >= 17)
{
    Console.WriteLine("yes");
}
else if (run >= 3)
{
    Console.WriteLine("No");
}
else
{
    Console.WriteLine("Invlid");
}
Console.ReadKey(true);