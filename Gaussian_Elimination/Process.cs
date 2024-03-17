using System.Numerics;
using Fractions;
namespace Gaussian_Elimination;

public class Process
{
    

    public static void Start_Function(Fraction[][] baseMatrixProblem_FractionArray2D, Fraction[][]baseMatrixVariable_FractionArray2D, Fraction[][] baseMatrixDestination_FractionArray2D,bool jordanElimination_Bool)
    {

        GaussianElimination_Function(baseMatrixProblem_FractionArray2D, baseMatrixVariable_FractionArray2D,baseMatrixDestination_FractionArray2D,jordanElimination_Bool);

    }

    private static void GaussianElimination_Function(Fraction[][] baseMatrixProblem_FractionArray2D, Fraction[][] baseMatrixDestination_FractionArray2D, Fraction[][]baseMatrixVariable_FractionArray2D,bool jordanElimination_Bool)
    {

        if(baseMatrixProblem_FractionArray2D.Length!=baseMatrixProblem_FractionArray2D[0].Length)return;

        Solver_Function(
            Elimination_Function(
                Sort_Function(
                    Merger_Function(
                        baseMatrixProblem_FractionArray2D,
                            baseMatrixDestination_FractionArray2D))));
    
    }

    private static void Solver_Function(Fraction[][] augmentedMatrix_FractionArray2D)
    {

        Spliter_Function(augmentedMatrix_FractionArray2D,out Fraction[][] problem_FractionArray2D,out  Fraction[][] destination_FractionArray2D);

        Fraction[] answers_StringArray2D = new Fraction[destination_FractionArray2D.Length];

        for (int variable_Int = 0; variable_Int < problem_FractionArray2D.Length; variable_Int++)
        {

            for (int variable_Int2 = 0; variable_Int2 < problem_FractionArray2D.Length; variable_Int2++)
            {

                //wtf fix<------------------------------------------------------------------------------------------------------------------------------------------------------------
                // answers_StringArray2D[variable_Int] = destination_FractionArray2D[variable_Int][variable_Int2]/problem_FractionArray2D[^1][^1];
                
            }            
            
        }

    }

    private static void Spliter_Function(Fraction[][] augmentedMatrix_FractionArray2D, out Fraction[][] problem_FractionArray2D, out Fraction[][] destination_FractionArray2D)
    {

        (problem_FractionArray2D,destination_FractionArray2D) = ([],[]);

        for (int row_Int = 0; row_Int < augmentedMatrix_FractionArray2D.Length; row_Int++)
        {

            problem_FractionArray2D[row_Int] = augmentedMatrix_FractionArray2D[row_Int][..augmentedMatrix_FractionArray2D.Length];

            destination_FractionArray2D[row_Int] = augmentedMatrix_FractionArray2D[row_Int][augmentedMatrix_FractionArray2D.Length..];
            
        }

    }

    private static Fraction[][] Merger_Function(Fraction[][] problem_FractionArray2D, Fraction[][] destination_FractionArray2D)
    {

        Fraction[][] augmented_FractionArray2D = [];

        for(int row_Int = 0; row_Int < problem_FractionArray2D.Length; row_Int++)
        {

            augmented_FractionArray2D[row_Int] = new Fraction[problem_FractionArray2D.Length+destination_FractionArray2D.Length];

            for (int column_Int = 0; column_Int < problem_FractionArray2D.Length; column_Int++)
            {

                augmented_FractionArray2D[row_Int][column_Int] = problem_FractionArray2D[row_Int][column_Int];
                
            }

            for (int column_Int = 0; column_Int < destination_FractionArray2D.Length; column_Int++)
            {

                augmented_FractionArray2D[row_Int][problem_FractionArray2D.Length+column_Int] = destination_FractionArray2D[row_Int][column_Int];
                
            }

        }

        return augmented_FractionArray2D;

    }

    private static Fraction[][] Elimination_Function(Fraction[][]augmented_FractionArray2D)
    {
        
        for(int row_Int = 0; row_Int<augmented_FractionArray2D.Length-1;row_Int++)
        {   

            for(int eliminationRow_Int = row_Int+1;eliminationRow_Int<augmented_FractionArray2D.Length;eliminationRow_Int++)
            {

                Fraction diagonalRow_FractionArray = augmented_FractionArray2D[eliminationRow_Int][row_Int]/augmented_FractionArray2D[row_Int][row_Int];

                for (int column_Int=0; column_Int < augmented_FractionArray2D[eliminationRow_Int].Length;column_Int++)
                {

                    augmented_FractionArray2D[eliminationRow_Int][column_Int]-=diagonalRow_FractionArray*augmented_FractionArray2D[row_Int][column_Int];
                    
                }

            }

        }

        return augmented_FractionArray2D;

    }

    static Fraction[][] Sort_Function(Fraction[][]augmented_FractionArray2D)
    {

        int arrayLength_Int = augmented_FractionArray2D.Length;

        Fraction[][] sortedAugmented_IntArray2D = new Fraction[arrayLength_Int][];

        Fraction[][] availableRows_IntArray2D = new Fraction[arrayLength_Int][];

        List<int> rows_IntList =[];

        List<int> rowsChoices_IntList = [];

        List<int> sortedRows_IntList = []; 

        List<int> usedRows_IntList = []; 

        for (int row_Int = 0; row_Int < arrayLength_Int; row_Int++)
        {

            sortedRows_IntList.Add(-1);

            rows_IntList.Add(row_Int);

            rowsChoices_IntList.Add(0);

            sortedAugmented_IntArray2D[row_Int] = new Fraction[arrayLength_Int];

            availableRows_IntArray2D[row_Int] = new Fraction[arrayLength_Int];
            
        }

        

        AssessMatrix_Function(availableRows_IntArray2D,out rowsChoices_IntList);

        for(int process_Int = 0; process_Int<arrayLength_Int; process_Int++)
        {

            int lowestChoiceIndex_Int = rowsChoices_IntList.IndexOf(rowsChoices_IntList.Where(x => x != 0).DefaultIfEmpty(-1).Min());
            
            if(lowestChoiceIndex_Int == -1)
            {            

                int unsortedRow_Int = sortedRows_IntList.IndexOf(-1);
                
                int unusedRow_Int = rows_IntList.IndexOf(rows_IntList.Where(row_Int => !sortedRows_IntList.Contains(row_Int) &
                    augmented_FractionArray2D[row_Int][unsortedRow_Int] != 0).DefaultIfEmpty(-1).First());

                if(unusedRow_Int==-1)
                {

                    System.Console.WriteLine("something went wrong while sorting!");
                    
                    return[];
                    
                }
                
                sortedRows_IntList[unsortedRow_Int] = unusedRow_Int;

                sortedAugmented_IntArray2D[unsortedRow_Int] = augmented_FractionArray2D[unusedRow_Int];

                for(int column_Int=0 ; column_Int<arrayLength_Int;column_Int++)
                {

                    availableRows_IntArray2D[unsortedRow_Int][column_Int] = 0;

                    availableRows_IntArray2D[column_Int][unusedRow_Int] = 0;

                }

            }else
            {            

                int leastDependencies_Int = (int)availableRows_IntArray2D[lowestChoiceIndex_Int].Max();

                int leastDependentRow_Int = availableRows_IntArray2D[lowestChoiceIndex_Int].ToList().IndexOf(leastDependencies_Int);

                for(int column_Int = 0; column_Int == arrayLength_Int; column_Int++)
                {

                    if(availableRows_IntArray2D[lowestChoiceIndex_Int][column_Int] != 0 & augmented_FractionArray2D[column_Int][lowestChoiceIndex_Int]!=0)
                    {

                        if(availableRows_IntArray2D[lowestChoiceIndex_Int][column_Int]<=leastDependentRow_Int)
                        {

                            leastDependencies_Int = (int)availableRows_IntArray2D[lowestChoiceIndex_Int][column_Int];
                            
                            leastDependentRow_Int = column_Int;
                            
                        }

                    }

                }

                sortedAugmented_IntArray2D[lowestChoiceIndex_Int] = augmented_FractionArray2D[leastDependentRow_Int];

                sortedRows_IntList[lowestChoiceIndex_Int] = leastDependentRow_Int;

                for(int column_Int=0 ; column_Int<arrayLength_Int;column_Int++)
                {

                    rowsChoices_IntList[lowestChoiceIndex_Int] = 0;

                    availableRows_IntArray2D[lowestChoiceIndex_Int][column_Int] = 0;

                    availableRows_IntArray2D[column_Int][leastDependentRow_Int] = 0;

                }

            }

            availableRows_IntArray2D = AssessMatrix_Function(availableRows_IntArray2D,out rowsChoices_IntList);            
        
        }

        return sortedAugmented_IntArray2D;

    }

    static void Show_Function(Fraction[][]availableRows_IntArray2D)
    {

        int arrayLength_Int = availableRows_IntArray2D.Length;

        for (int row_Int = 0; row_Int < arrayLength_Int; row_Int++)
        {

            System.Console.Write($"Row {row_Int+1}: ");

            for(int column_Int = 0; column_Int<arrayLength_Int; column_Int++)
            {

                if(availableRows_IntArray2D[row_Int][column_Int] >= 0)
                {

                    System.Console.Write($" {availableRows_IntArray2D[row_Int][column_Int]} ");

                }else
                {

                    System.Console.Write($"{availableRows_IntArray2D[row_Int][column_Int]} ");

                }

            }

        }

        System.Console.WriteLine();

        System.Console.WriteLine("------------------------------------------------");

        System.Console.WriteLine();

    }

    static Fraction[][] AssessMatrix_Function(Fraction[][] matrix_IntArray2D, out List<int>rowsChoices_IntList)
    {

        int arrayLength_Int = matrix_IntArray2D.Length;

        List<int> independencyRank_IntList = [];

        rowsChoices_IntList = [];

        for (int row_Int = 0; row_Int < arrayLength_Int; row_Int++)
        {

            rowsChoices_IntList.Add(0);

            independencyRank_IntList.Add(0);

            for(int column_Int = 0; column_Int<arrayLength_Int; column_Int++)
            {

                if(matrix_IntArray2D[column_Int][row_Int] != 0)independencyRank_IntList[row_Int]++;
            
            }

        }

        for (int row_Int = 0; row_Int < arrayLength_Int; row_Int++)
        {

            for(int column_Int = 0; column_Int<arrayLength_Int; column_Int++)
            {

                int chosenNumbers_Int = 0;

                if(matrix_IntArray2D[row_Int][column_Int] != 0)
                {

                    rowsChoices_IntList[row_Int]++;

                    chosenNumbers_Int = independencyRank_IntList[column_Int];

                    if(matrix_IntArray2D[column_Int][row_Int]!=0)chosenNumbers_Int--;

                    if(chosenNumbers_Int == 0)chosenNumbers_Int++;

                }

                matrix_IntArray2D[row_Int][column_Int] = chosenNumbers_Int;

            }

        }

        return matrix_IntArray2D;

    }

}