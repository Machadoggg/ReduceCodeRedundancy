
using System.ComponentModel;

int age = 40;
string message = "";

//if (age >= 18)
//{
//    message = "Es mayor de edad";
//}
//else 
//{
//    message = "Es menor de edad";
//}

// use ternary operator (? / true : false) if the answer is a binary scenario
// obtain var value (message)
message = (age >= 18) ? "Es mayor de edad" : "Es menor de edad";

Console.WriteLine(message);

//-----------------------------------------------------------------------------//

string? category = null;
string name = "";

if (category != null)
{
    name = category;
}
else
{
    name = "Otra";
}

Console.WriteLine(name);