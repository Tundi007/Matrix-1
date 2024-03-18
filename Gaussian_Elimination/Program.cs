using Fractions;
namespace Gaussian_Elimination;

class Program
{

    [STAThread]
    public static void Main(string[] args)
    {

        Fraction[][] problem1_FractionArray2D = [[],[]];

        Fraction[][] destination1_FractionArray2D = [[],[]];

        Fraction[][] problem2_FractionArray2D = [[],[]];

        Process.Start_Function(problem1_FractionArray2D,destination1_FractionArray2D,false);

        System.Console.WriteLine("Press Anything To Continue");

        Process.Start_Function(problem2_FractionArray2D,[],true);


                
    }

}