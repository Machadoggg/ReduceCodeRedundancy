
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


//-------------------------TERNARY OPERATOR--------------------------------------//
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




//-------------------------Null-Coalescing Operator--------------------------------------//

//string? category = null;
//string name = "";

//if (category != null)
//{
//    name = category;
//}
//else
//{
//    name = "Otra";
//}

string? category = null;

string name = category ?? "Otro";

Console.WriteLine(name);





//--------------------------Evaluate Car null-----------------------------------//


//Car car = null;

//if (car != null)
//{
//    Console.WriteLine(car.Brand);
//}
//record Car(string Brand, string Model);

// Use NULL conditional (?)
// to evaluate if car is null
// if encadenate Console.WriteLine(car?.Brand?.?. ...);
Car car = null;

if (car != null)
{
    Console.WriteLine(car?.Brand);
}
record Car(string Brand, string Model);