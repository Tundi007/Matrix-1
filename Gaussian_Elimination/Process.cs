using System.Numerics;
using MathNet.Numerics;
using MathNet.Symbolics;
namespace Gaussian_Elimination;

public class Process
{

    private static List<string[][]> dataListPrivate_StringList2D = [];

    private static void RefrenceData_Function()
    {

        dataListPrivate_StringList2D = IData.GetAllDataSets_Function();

    }


    private static void GaussianElimination_Function(int matrixProblem_Int, int matrixDestination_Int, bool jordanElimination_Bool)
    {

        int[][] baseMatrixProblem_StringArray2D = ;

        int[][] baseMatrixDestination_StringArray2D;
        
        int totalRow_Int = baseMatrixProblem_StringArray2D.Length;                

        int totalColumn_Int = baseMatrixProblem_StringArray2D[0].Length;

        if(totalColumn_Int!=totalRow_Int)return; // check first if length of arrays are ok then proceed

        int jordanRule_Int = 1;

        if(jordanElimination_Bool)jordanRule_Int = totalColumn_Int*2;

        string[] baseMatrixVariable_StringArray2D = new string[totalRow_Int];

        int[][] augmentedMatrix_StringArray2D = Merger_Function(jordanRule_Int,baseMatrixProblem_StringArray2D,baseMatrixDestination_StringArray2D);        

        for (int variableNumber_Int = 0; variableNumber_Int < totalRow_Int; variableNumber_Int++)
        {

            baseMatrixVariable_StringArray2D[variableNumber_Int] = string.Format($"x{variableNumber_Int}");
            
        }

        for (int currentColumn_Int = 0; currentColumn_Int < totalRow_Int; currentColumn_Int++)
        {

            augmentedMatrix_StringArray2D = Elimination_Function(augmentedMatrix_StringArray2D,currentColumn_Int);

        }

        
    }

    private static int[][] Merger_Function(int jordanRule_Int, int[][] problem_StringArray2D, int[][] destination_StringArray2D)
    {

        int[][] augmented_StringArray2D = [];

        int totalRow_Int = problem_StringArray2D.Length;

        int totalColumn_Int = problem_StringArray2D[0].Length;

        for(int row_Int = 0; row_Int < totalRow_Int; row_Int++)
        {

            augmented_StringArray2D[row_Int] = new int[totalColumn_Int+1];

            for (int column_Int = 0; column_Int < totalColumn_Int; column_Int++)
            {

                augmented_StringArray2D[row_Int][column_Int] = problem_StringArray2D[row_Int][column_Int];
                
            }

            for (int column_Int = 0; column_Int < jordanRule_Int; column_Int++)
            {

                augmented_StringArray2D[row_Int][totalColumn_Int+column_Int] = destination_StringArray2D[row_Int][column_Int];
                
            }               

        }

        return augmented_StringArray2D;

    }

    private static int[][] Elimination_Function(int[][]augmented_StringArray2D,int currentColumn_Int)
    {

        (int totalRow_Int, int totalColumn_Int) = (augmented_StringArray2D.Length,augmented_StringArray2D[0].Length);

        if(augmented_StringArray2D[currentColumn_Int][currentColumn_Int]==0)
        {

            (augmented_StringArray2D[currentColumn_Int],
                augmented_StringArray2D[SortColumn_Function(augmented_StringArray2D, currentColumn_Int)])=
                    (augmented_StringArray2D[SortColumn_Function(augmented_StringArray2D, currentColumn_Int)],
                        augmented_StringArray2D[currentColumn_Int]);

        }

        for (int currentrow_Int = currentColumn_Int; currentrow_Int < totalRow_Int; currentrow_Int++)
        {            
            
        }

        return[];

    }

    private static int SortColumn_Function(int[][]augmented_StringArray2D,int currentColumn_Int)
    {        

        int lowestElement_Int = currentColumn_Int; //non-zero

        for (int row_int = currentColumn_Int; row_int < augmented_StringArray2D.Length; row_int++)
        {

            if(augmented_StringArray2D[row_int][currentColumn_Int]!=0)
            {

                lowestElement_Int = row_int;

            }
            
        }

        return lowestElement_Int;

    }



    private static void _Function(){}

}