System.Console.WriteLine("Ikkita butun son kiriting: ");
System.Console.Write("birinchi son: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("ikkinchi son: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ikkita son orasida bajariladigan operatorni (+,-,*,/,%) kiriting:");
string operation = Console.ReadLine();

switch (operation)
{
    case "+":
        System.Console.WriteLine($"{firstnumber} + {secondnumber} = {firstnumber + secondnumber}");
        break;
    case "-":
        System.Console.WriteLine($"{firstnumber} - {secondnumber} = {firstnumber - secondnumber}");
        break;
    case "*":
        System.Console.WriteLine($"{firstnumber} * {secondnumber} = {firstnumber * secondnumber}");
        break;
    case "/":
        System.Console.WriteLine($"{firstnumber} / {secondnumber} = {(double)firstnumber / (double)secondnumber}");
        break;
    case "%":
        System.Console.WriteLine($"{firstnumber} % {secondnumber} = {firstnumber % secondnumber}");
        break;
    default:
    System.Console.WriteLine("Operator topilmadi!!!");
    break;
}


Console.ReadKey();

