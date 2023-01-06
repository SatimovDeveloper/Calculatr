System.Console.WriteLine("Ikkita butun son kiriting: ");
System.Console.Write("birinchi son: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("ikkinchi son: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ikkita son orasida bajariladigan operatorni (+,-,*,/,%) kiriting:");
string operation = Console.ReadLine();

string natija = operation switch
{
    "+" => $"{firstnumber} + {secondnumber} = {firstnumber + secondnumber}",
    "-" => $"{firstnumber} - {secondnumber} = {firstnumber - secondnumber}",
    "*" => $"{firstnumber} * {secondnumber} = {firstnumber * secondnumber}",
    "/" => $"{firstnumber} / {secondnumber} = {(double)firstnumber / (double)secondnumber}",
    "%" => $"{firstnumber} % {secondnumber} = {firstnumber % secondnumber}",
    _   => "Operator topilmadi"
};

System.Console.WriteLine(natija);



// switch (operation)
// {
//     case "+":
//         System.Console.WriteLine($"{firstnumber} + {secondnumber} = {firstnumber + secondnumber}");
//         break;
//     case "-":
//         System.Console.WriteLine($"{firstnumber} - {secondnumber} = {firstnumber - secondnumber}");
//         break;
//     case "*":
//         System.Console.WriteLine($"{firstnumber} * {secondnumber} = {firstnumber * secondnumber}");
//         break;
//     case "/":
//         System.Console.WriteLine($"{firstnumber} / {secondnumber} = {(double)firstnumber / (double)secondnumber}");
//         break;
//     case "%":
//         System.Console.WriteLine($"{firstnumber} % {secondnumber} = {firstnumber % secondnumber}");
//         break;
//     default:
//     System.Console.WriteLine("Operator topilmadi!!!");
//     break;
// }


Console.ReadKey();

