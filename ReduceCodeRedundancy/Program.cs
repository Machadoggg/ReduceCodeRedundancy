
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
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


        //--------------------------2 List in second list add all names init with (A)-----------------------------------//

        List<string> names = new()
        {
            "Ana", "Juan", "Alejandro"
        };

        //List<string> names2 = new();

        //foreach (string name2 in names)
        //{
        //    if (name2.ToUpper()[0] == 'A')
        //    {
        //        names2.Add(name2);
        //    }
        //}

        // Use LINQ with the same condition
        List<string> names2 = names.Where(n => n.ToUpper()[0] == 'A').ToList();

        //return;





        //--------------------------SWITCH CASE-----------------------------------//

        int op = 2;

        //switch (op)
        //{
        //    case 1:
        //        Console.WriteLine("Opción 1 seleccionada");
        //        break;
        //    case 2:
        //        Console.WriteLine("Opción 2 seleccionada");
        //        break;
        //    case 3:
        //        Console.WriteLine("Opción 3 seleccionada");
        //        break;
        //    default:
        //        Console.WriteLine("Opción válida");
        //        break;
        //}

        // create array with save behaviors
        Action[] actions = new Action[]
        {
            () => Console.WriteLine("Opción 1 seleccionada"),
            () => Console.WriteLine("Opción 2 seleccionada"),
            () => Console.WriteLine("Opción 3 seleccionada"),
            () => Console.WriteLine("Opción 4 seleccionada")
        };

        if (op > 0 && op <= actions.Length)
        {
            actions[op - 1]();
        }
        else
        {
            Console.WriteLine("Opción no valida");
        }




        





    }
    //--------------------------Generic Functions-----------------------------------//

    class Operations
    {
        //public int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //public double Add(double a, double b)
        //{
        //    return a + b;
        //}

        public T Add<T>(T a, T b) where T : struct
        {
            return (dynamic)a + (dynamic)b;
        }
    }
}
record Car(string Brand, string Model);