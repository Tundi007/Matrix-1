using Fractions;
namespace Gaussian_Elimination;

class Program
{

    [STAThread]
    public static void Main(string[] args)
    {

        Fraction[][] problem1_FractionArray2D = [[0,0,1,0],[new Fraction(1,4),new Fraction(1,4),new Fraction(1,4),new Fraction(1,4)],[0,0,new Fraction(1,2),new Fraction(1,2)],[1,0,0,0]];        

        Fraction[][] destination1_FractionArray2D = [[1],[new Fraction(1,4)],[1],[1]];

        Fraction[][] problem2_FractionArray2D = [[0,0,2,3,],[0,-1,1,3],[1,3,-1,0],[1,2,0,0]];

        System.Console.WriteLine("Answer 1");

        Process.Start_Function(problem1_FractionArray2D,destination1_FractionArray2D,false);

        System.Console.WriteLine("Press Anything To Continue");

        Console.ReadKey(true);

        System.Console.WriteLine("Answer 2");

        Process.Start_Function(problem2_FractionArray2D,[],true);


                
    }

}