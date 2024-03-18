using Fractions;
namespace Gaussian_Elimination;

public class Process
{

    public static void Start_Function(Fraction[][] baseMatrixProblem_FractionArray2D, Fraction[][] baseMatrixDestination_FractionArray2D,bool jordanElimination_Bool)
    {

        if(jordanElimination_Bool)
            JordanGaussian_Function(baseMatrixProblem_FractionArray2D);
        else
            Gaussian_Function(baseMatrixProblem_FractionArray2D, baseMatrixDestination_FractionArray2D);

    }

    private static void Gaussian_Function(Fraction[][] baseMatrixProblem_FractionArray2D, Fraction[][] baseMatrixDestination_FractionArray2D)
    {

        Fraction[] answer_FractionArray =
            NormalSolver_Function(
                NormalElimination_Function(
                    Sort_Function(
                        Merger_Function(
                            baseMatrixProblem_FractionArray2D,
                                baseMatrixDestination_FractionArray2D))));

        for (int variable_Int = 0; variable_Int < answer_FractionArray.Length; variable_Int++)
        {

            System.Console.WriteLine($"Value Of Variable'{variable_Int}' = {answer_FractionArray[variable_Int]}");
            
        }
    
    }

    private static Fraction[][] Merger_Function(Fraction[][] problem_FractionArray2D, Fraction[][] destination_FractionArray2D)
    {

        Fraction[][] augmented_FractionArray2D = new Fraction[problem_FractionArray2D.Length][];

        for(int row_Int = 0; row_Int < augmented_FractionArray2D.Length; row_Int++)
        {

            augmented_FractionArray2D[row_Int] = new Fraction[problem_FractionArray2D.Length + destination_FractionArray2D.Length];

            for (int column_Int = 0; column_Int < problem_FractionArray2D[row_Int].Length; column_Int++)
            {

                augmented_FractionArray2D[row_Int][column_Int] = problem_FractionArray2D[row_Int][column_Int];
                
            }

            for (int column_Int = 0; column_Int < destination_FractionArray2D[row_Int].Length; column_Int++)
            {

                augmented_FractionArray2D[row_Int][problem_FractionArray2D[row_Int].Length+column_Int] = destination_FractionArray2D[row_Int][column_Int];
                
            }

        }

        return augmented_FractionArray2D;

    }

    private static Fraction[][] Sort_Function(Fraction[][]augmented_FractionArray2D)
    {    

        List<int> sorted_IntList = [];

        for (int count_Int = 0; count_Int < augmented_FractionArray2D.Length; count_Int++)
        {
        
            sorted_IntList.Add(0);
            
        }

        int checkContinue = 0;

        bool check_Bool = true;

        for (int process_Int = 0; process_Int < augmented_FractionArray2D.Length; process_Int++)
        {

            if(check_Bool)
            for (int check_Int = checkContinue; check_Int < augmented_FractionArray2D.Length; check_Int++)
            {

                if(check_Int == augmented_FractionArray2D.Length-1)check_Bool = false;

                if(augmented_FractionArray2D[check_Int][check_Int]==0)
                {

                    checkContinue = check_Int+1;

                    int index_Int = check_Int;

                    bool initialize_Bool = true;

                    for (int option_Int = 0; option_Int < augmented_FractionArray2D.Length; option_Int++)
                    {

                        if(augmented_FractionArray2D[option_Int][check_Int] != 0 &
                                sorted_IntList[option_Int] == 0)
                        {

                            if(!initialize_Bool &
                                augmented_FractionArray2D[check_Int][index_Int].Abs() >
                                    augmented_FractionArray2D[check_Int][option_Int].Abs())
                                index_Int = option_Int;
                            else
                            {

                                initialize_Bool = false;

                                index_Int = option_Int;

                            }
                            
                        }
                        
                    }

                    (augmented_FractionArray2D[index_Int], augmented_FractionArray2D[check_Int]) =
                            (augmented_FractionArray2D[check_Int], augmented_FractionArray2D[index_Int]);

                    sorted_IntList[check_Int] = 1;

                    break;
                
                }

            }else
            {

                for (int row_Int = 0; row_Int < augmented_FractionArray2D.Length; row_Int++)
                {

                    if(sorted_IntList[row_Int]==0)
                    {
                
                        int index_Int = row_Int;

                        bool initialize_Bool = true;
                        
                        for (int option_Int = 0; option_Int < augmented_FractionArray2D.Length; option_Int++)
                        {

                            if(sorted_IntList[option_Int] == 0 &
                                augmented_FractionArray2D[option_Int][row_Int] != 0 &
                                    augmented_FractionArray2D[option_Int][row_Int].Abs() <
                                        augmented_FractionArray2D[row_Int][row_Int].Abs() &                            
                                            augmented_FractionArray2D[row_Int][option_Int] != 0 &
                                                augmented_FractionArray2D[row_Int][option_Int].Abs() >
                                                    augmented_FractionArray2D[option_Int][row_Int].Abs())
                                if(!initialize_Bool &
                                    augmented_FractionArray2D[row_Int][index_Int].Abs() >
                                        augmented_FractionArray2D[row_Int][option_Int].Abs())
                                    index_Int = option_Int;
                                else
                                {

                                    initialize_Bool = false;

                                    index_Int = option_Int;

                                }

                        }

                        if(index_Int == row_Int)break;

                        (augmented_FractionArray2D[index_Int], augmented_FractionArray2D[row_Int]) =
                            (augmented_FractionArray2D[row_Int], augmented_FractionArray2D[index_Int]);

                        sorted_IntList[row_Int] = 1;

                        break;

                    }
                    
                }

            }

        }

        return augmented_FractionArray2D;

    }

    private static Fraction[][] NormalElimination_Function(Fraction[][]augmented_FractionArray2D)
    {
        
        for(int row_Int = 0; row_Int<augmented_FractionArray2D.Length-1;row_Int++)
        {   

            for(int eliminationRow_Int = row_Int+1;eliminationRow_Int<augmented_FractionArray2D.Length;eliminationRow_Int++)
            {

                Fraction diagonalRow_FractionArray = augmented_FractionArray2D[eliminationRow_Int][row_Int]/augmented_FractionArray2D[row_Int][row_Int];

                for (int nextRow_Int=0; nextRow_Int < augmented_FractionArray2D[eliminationRow_Int].Length;nextRow_Int++)
                {

                    augmented_FractionArray2D[eliminationRow_Int][nextRow_Int] -= diagonalRow_FractionArray*augmented_FractionArray2D[row_Int][nextRow_Int];
                    
                }

            }

        }

        return augmented_FractionArray2D;

    }

    private static void Spliter_Function(Fraction[][] augmentedMatrix_FractionArray2D, out Fraction[][] problem_FractionArray2D, out Fraction[][] destination_FractionArray2D)
    {

        (problem_FractionArray2D,
            destination_FractionArray2D) =
                (new Fraction[augmentedMatrix_FractionArray2D.Length][],
                    new Fraction[augmentedMatrix_FractionArray2D.Length][]);

        for (int row_Int = 0; row_Int < augmentedMatrix_FractionArray2D.Length; row_Int++)
        {

            problem_FractionArray2D[row_Int] = augmentedMatrix_FractionArray2D[row_Int][..augmentedMatrix_FractionArray2D.Length];

            destination_FractionArray2D[row_Int] = augmentedMatrix_FractionArray2D[row_Int][augmentedMatrix_FractionArray2D.Length..];
            
        }

    }

    private static Fraction[] NormalSolver_Function(Fraction[][] augmentedMatrix_FractionArray2D)
    {

        Spliter_Function(augmentedMatrix_FractionArray2D,out Fraction[][] problem_FractionArray2D,out  Fraction[][] destination_FractionArray2D);

        Fraction[] answers_StringArray2D = new Fraction[destination_FractionArray2D.Length];

        answers_StringArray2D[0] =
            destination_FractionArray2D[^1][^1]/
                problem_FractionArray2D[^1][^1];

        for (int variable_Int = 1; variable_Int < answers_StringArray2D.Length; variable_Int++)
        {
         
            answers_StringArray2D[variable_Int] = (destination_FractionArray2D[variable_Int][0] - RecursiveSolve_Function(answers_StringArray2D,problem_FractionArray2D,variable_Int,variable_Int-1))/problem_FractionArray2D[variable_Int][variable_Int];
                
        }

        return answers_StringArray2D;

    }

    private static Fraction RecursiveSolve_Function(Fraction[]answers_StringArray2D, Fraction[][] problem_FractionArray2D,int const_Int ,int variable_Int)
    {

        if(variable_Int == 0) return answers_StringArray2D[0]*
                problem_FractionArray2D[const_Int][0];

        return answers_StringArray2D[variable_Int]*problem_FractionArray2D[const_Int][variable_Int] +
            RecursiveSolve_Function(answers_StringArray2D,problem_FractionArray2D,const_Int,variable_Int-1);

    }
    
    private static void JordanGaussian_Function(Fraction[][] baseMatrixProblem_FractionArray2D)
    {

        Fraction[][] baseMatrixDestination_FractionArray2D = new Fraction[baseMatrixProblem_FractionArray2D.Length][];

        for (int row_Int = 0; row_Int < baseMatrixDestination_FractionArray2D.Length; row_Int++)
        {

            baseMatrixDestination_FractionArray2D[row_Int] = new Fraction[baseMatrixDestination_FractionArray2D.Length];

            baseMatrixDestination_FractionArray2D[row_Int][row_Int] = 1;
            
        }
        
        Fraction[][] answerJordan_FractionArray2D =
            JordanSolver_Function(
                JordanElimination_Function(
                    Sort_Function(
                        Merger_Function(
                            baseMatrixProblem_FractionArray2D,
                                baseMatrixDestination_FractionArray2D))));

        Show_Function(answerJordan_FractionArray2D);
                
    }
    
    private static Fraction[][] JordanElimination_Function(Fraction[][]augmented_FractionArray2D)
    {
        
        for(int row_Int = 0; row_Int<augmented_FractionArray2D.Length-1;row_Int++)
        {

            for(int eliminationRow_Int = row_Int+1;eliminationRow_Int<augmented_FractionArray2D.Length;eliminationRow_Int++)
            {

                if(augmented_FractionArray2D[row_Int][row_Int]==0)augmented_FractionArray2D = Sort_Function(augmented_FractionArray2D);

                Fraction diagonalRow_FractionArray =
                    augmented_FractionArray2D[eliminationRow_Int][row_Int] /
                        augmented_FractionArray2D[row_Int][row_Int];

                for (int nextRow_Int=0; nextRow_Int < augmented_FractionArray2D[eliminationRow_Int].Length;nextRow_Int++)
                {

                    augmented_FractionArray2D[eliminationRow_Int][nextRow_Int] -=
                        diagonalRow_FractionArray *
                            augmented_FractionArray2D[row_Int][nextRow_Int];
                    
                }

            }

        }

        for(int row_Int = augmented_FractionArray2D.Length-1; row_Int>-1;row_Int--)
        {   

            if(augmented_FractionArray2D[row_Int][row_Int]==0)augmented_FractionArray2D = Sort_Function(augmented_FractionArray2D);

            for(int eliminationRow_Int = row_Int-1;eliminationRow_Int>-1;eliminationRow_Int--)
            {

                Fraction diagonalRow_FractionArray =
                    augmented_FractionArray2D[eliminationRow_Int][row_Int] /
                        augmented_FractionArray2D[row_Int][row_Int];

                for (int column_Int=0; column_Int < augmented_FractionArray2D[eliminationRow_Int].Length;column_Int++)
                {

                    augmented_FractionArray2D[eliminationRow_Int][column_Int] -=
                        diagonalRow_FractionArray *
                            augmented_FractionArray2D[row_Int][column_Int];
                    
                }

            }

        }

        for(int row_Int = 0; row_Int<augmented_FractionArray2D.Length;row_Int++)
        {

            Fraction diagonalRow_FractionArray = new(1,augmented_FractionArray2D[row_Int][row_Int].ToBigInteger(),true);

            for (int column_Int=0; column_Int < augmented_FractionArray2D[row_Int].Length;column_Int++)
            {

                augmented_FractionArray2D[row_Int][column_Int] *= diagonalRow_FractionArray;
                
            }

        }

        return augmented_FractionArray2D;

    }

    private static Fraction[][] JordanSolver_Function(Fraction[][] augmentedMatrix_FractionArray2D)
    {

        Spliter_Function(augmentedMatrix_FractionArray2D,out _,out  Fraction[][] destination_FractionArray2D);

        return destination_FractionArray2D;

    }
    
    private static void Show_Function(Fraction[][]augmented_FractionArray2D)
    {
        
        int count_Int = 0;

        foreach (Fraction[] row in augmented_FractionArray2D)
        {

            System.Console.Write($"Row {count_Int+1}: ");

            count_Int++;

            foreach (Fraction element in row)
            {

                if(element<0 & element.Denominator!=1)
                    System.Console.Write($"{element} ");else
                if(element>0 & element.Denominator!=1)
                    System.Console.Write($" {element} ");else
                if(element>0 & element.Denominator==1)
                    System.Console.Write($"   {element} ");else
                if(element<0 & element.Denominator==1)
                    System.Console.Write($"  {element} ");else
                if (element==0)
                    System.Console.Write($"   {element} ");
                
            }

            System.Console.WriteLine();
            
        }

    }

}