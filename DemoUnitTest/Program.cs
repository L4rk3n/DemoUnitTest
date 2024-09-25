using DemoUnitTest;


Calcul calcul = new Calcul();
try
{
    Console.WriteLine(calcul.Addition(int.MaxValue, 10));

}
catch(Exception ex)
{
    Console.WriteLine("Une erreur s'est produite ");
}
try
{
    Console.WriteLine(calcul.Soustraction(int.MinValue, 10));

}
catch (Exception ex2)
{
    Console.WriteLine("Une erreur s'est produite ");
}
try
{
    Console.WriteLine(calcul.Division(int.MinValue, 10));

}
catch (Exception ex3)
{
    Console.WriteLine("Une erreur s'est produite ");
}
try
{
    Console.WriteLine(calcul.Multiplication(int.MaxValue, 10));

}
catch (Exception ex4)
{
    Console.WriteLine("Une erreur s'est produite ");
}