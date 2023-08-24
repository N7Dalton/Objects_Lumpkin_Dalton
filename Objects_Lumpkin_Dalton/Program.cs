// See https://aka.ms/new-console-template for more information
using Objects_Lumpkin_Dalton;
using System.Linq;


Computer c = new Computer("Dell", "Laptop", false);

//makes a new IBootUp Object referencing c, iC
IBootUp iC = c;

//prints the comparrisonbetween c and iC
Console.WriteLine(c.Equals(iC));

//makes another new Computer object c2
Computer c2 = new Computer("Dell", "Laptop", false);

//prints the comparison between c and c2
Console.WriteLine(c2.Equals(c));

//assigns a new string description of c2.ToString()
string computerDescription = c2.ToString();

//compares the description to both computers.to string
Console.WriteLine(computerDescription.Equals(c2.ToString()));
Console.WriteLine(computerDescription.Equals(c.ToString()));

//prints both computers GetType function
Console.WriteLine(c.GetType());
Console.WriteLine(iC.GetType());

//calls the poweroff function on c
c.PowerOnOff();

//checks if the description contains the char i
Console.WriteLine(computerDescription.Contains('i'));

//prints to console the all uppercase description
Console.WriteLine(computerDescription.ToUpper());