// using System.Text.RegularExpressions;
// using System.Security.Cryptography; 
// using System.Text.RegularExpressions;
// string userAddress_Strin2g = null;
// if((userAddress_Strin2g??="a")==null){System.Console.WriteLine("null");}else{System.Console.WriteLine(userAddress_Strin2g);}
// // ConsoleKeyInfo a = Console.ReadKey(true);
// string userAddress_String = Console.ReadLine();
// Console.WriteLine(a.KeyChar.ToString());
// System.Console.WriteLine(IRead.KeyToLine_Function());

// string exitCode_String = RandomNumberGenerator.GetInt32(65535).ToString();

// System.Console.WriteLine(exitCode_String);

// Thread.Sleep(1500);

// string a = IRead.KeyToLine_Function(exitCode_String);

// System.Console.WriteLine(a);

// if(exitCode_String == a)return;

// System.Console.WriteLine(Regex.IsMatch(a, @".*" + exitCode_String + @"$"));
// string[][] a = new string[10][];
// a[0] = new string[10];
// a[0][4]="A";
// foreach (var item in a[0])
// {

//     System.Console.WriteLine(item);

// }

// int defaultValue = 42; // Set your desired default value
// int[][] customDefaultArray = new int[2][];
// for (int i = 0; i < customDefaultArray.Length; i++)customDefaultArray[i] = Enumerable.Repeat(defaultValue, 5).ToArray();
// foreach (var item in customDefaultArray[0])System.Console.WriteLine(item);    
// int a = 1;
// try
// {

//     a= 5;

//     System.Console.WriteLine(a);

// }
// catch (System.Exception)
// {

//     a=2;

//     throw;
// }

// System.Console.WriteLine(a);

// using System.Globalization;
// using System.Text.RegularExpressions;

// string? a = "ad , , 012 , ,m@nv-,zlm ,asd!a*&(@A> , , , ,,";

// while(!string.IsNullOrEmpty(a))
// {

//     Match c = MyRegex().Match(a);

//     a = a.Remove(0,c.ToString().Length);

//     string b = c.ToString().Replace(",",null).Trim();

//     if(string.IsNullOrWhiteSpace(b)) b = "_";

//     System.Console.WriteLine(b);

// }

// partial class Program
// {
//     [GeneratedRegex(@"(?<Element>,?[^,]+|,?\s*)|(?<NA>.*)?")]
//     private static partial Regex MyRegex();
// }

// string[][] a=[];

// a = [["2"],[],[]];

// a[1] = ["2","a"];

// a[2] = ["2","wow","z","x","2"];

// a[2][3] = "hi";

// foreach (string[] b in a)
// {

//     foreach (string c in b)
//     {

//         System.Console.WriteLine(c);

//     }

// }

// string[] d = ["changed","woah"];

// a[2] = d;

// foreach (string[] b in a)
// {

//     foreach (string c in b)
//     {

//         System.Console.WriteLine(c);

//     }

// }

// string[][] a =[["3"],["1","2"]];

// foreach (string[] b in a)
// {

//     foreach (string c in b)
//     {

//         System.Console.WriteLine(c);

//     }

// }

// System.Console.WriteLine("-----------");

// (a[0],a[1])=(a[1],a[0]);


// foreach (string[] b in a)
// {

//     foreach (string c in b)
//     {

//         System.Console.WriteLine(c);

//     }

// }

// Action<string> messageTarget;

// string? input = Console.ReadLine();

// input??="";

// if (input.Length > 5) messageTarget = ShowWindowsMessage;
// else messageTarget = Console.WriteLine;

// messageTarget(input);

// static void ShowWindowsMessage(string message)
// {

// System.Console.WriteLine(message + " is longer than 5 characters!");

// using System.Security.Cryptography;

// string a = RandomNumberGenerator.GetInt32(65355).ToString();

// string b="";

// if((b=IRead.KeyToLine_Function(a)).Contains(a))
// {
//     return;

// }

// decimal a = (decimal)2/53;

// // System.Console.WriteLine(a);

// using Fractions;

// Fraction b = 4;

// Fraction c = 6;

// Fraction a = b/c*3/2;

// System.Console.WriteLine(a - 1);

// using Fractions;

// Fraction[][] augmented_FractionArray2D = [[2,1,7,42,6],[3,2,8,17,0],[0,3,4,531,4],[1,4,5,3,2]];

// Fraction[][] backup_FractionArray2D = [[2,1,7,42,6],[3,2,8,17,0],[0,3,4,531,4],[1,4,5,3,2]];

// foreach(Fraction[] augmentArray_FractionArray in augmented_FractionArray2D)
// {
    
//     foreach (Fraction element_Fraction in augmentArray_FractionArray)
//     {

//         System.Console.Write($"{element_Fraction} ");
        
//     }

//     System.Console.WriteLine();
    
// }

// System.Console.WriteLine();
// System.Console.WriteLine();

// for(int row_Int = 0; row_Int<augmented_FractionArray2D.Length-1;row_Int++)
// {   

//     for(int eliminationRow_Int = row_Int+1;eliminationRow_Int<augmented_FractionArray2D.Length;eliminationRow_Int++)
//     {

//         Fraction diagonalRow_FractionArray = augmented_FractionArray2D[eliminationRow_Int][row_Int]/augmented_FractionArray2D[row_Int][row_Int];

//         for (int nextRow_Int=0; nextRow_Int < augmented_FractionArray2D[eliminationRow_Int].Length;nextRow_Int++)
//         {

//             augmented_FractionArray2D[eliminationRow_Int][nextRow_Int]-=diagonalRow_FractionArray*augmented_FractionArray2D[row_Int][nextRow_Int];
            
//         }

//         System.Console.WriteLine("changes:");

//         foreach(Fraction[] augmentArray_FractionArray in augmented_FractionArray2D)
//         {
            
//             foreach (Fraction element_Fraction in augmentArray_FractionArray)
//             {

//                 System.Console.Write($"{element_Fraction} ");
                
//             }

//             System.Console.WriteLine();
            
//         }

//         System.Console.WriteLine("-------------------");

//     }

// }

// System.Console.WriteLine();

// System.Console.WriteLine();

// System.Console.WriteLine("Old Matrix");

// for(int row_Int = 0; row_Int < backup_FractionArray2D.Length;row_Int++)
// {

//     System.Console.Write($"Row {row_Int}: ");
    
//     for(int nextRow_Int = 0; nextRow_Int < backup_FractionArray2D[row_Int].Length;nextRow_Int++)
//     {

//         System.Console.Write($"{backup_FractionArray2D[row_Int][nextRow_Int]} ");
        
//     }

//     System.Console.WriteLine();
    
// }

// System.Console.WriteLine("Final Matrix");

// for(int row_Int = 0; row_Int < augmented_FractionArray2D.Length;row_Int++)
// {

//     System.Console.Write($"Row {row_Int}: ");
    
//     for(int nextRow_Int = 0; nextRow_Int < augmented_FractionArray2D[row_Int].Length;nextRow_Int++)
//     {

//         System.Console.Write($"{augmented_FractionArray2D[row_Int][nextRow_Int]} ");
        
//     }

//     System.Console.WriteLine();
    
// }

// int[] a = [1,2,3,4,5,6];

// foreach (int b in a[..2])
// {

//     System.Console.WriteLine(b);

// }
// foreach (int b in a[2..])
// {

//     System.Console.WriteLine(b);

// }

// using Fractions;

// Fraction[][] augmentedMatrix_FractionArray2D =[[1,2,3,1],[4,5,6,2],[7,8,9,3]];

// System.Console.WriteLine(augmentedMatrix_FractionArray2D[^1][^2]);

// (Fraction[][] problem_FractionArray2D,
//     Fraction[][]destination_FractionArray2D) =
//         (new Fraction[augmentedMatrix_FractionArray2D.Length][],
//             new Fraction[augmentedMatrix_FractionArray2D.Length][]);

// for (int row_Int = 0; row_Int < augmentedMatrix_FractionArray2D.Length; row_Int++)
// {

//     problem_FractionArray2D[row_Int] = augmentedMatrix_FractionArray2D[row_Int][..augmentedMatrix_FractionArray2D.Length];

//     destination_FractionArray2D[row_Int] = augmentedMatrix_FractionArray2D[row_Int][augmentedMatrix_FractionArray2D.Length..];
    
// }

// foreach (Fraction[] array in augmentedMatrix_FractionArray2D)
// {

//     foreach (Fraction element in array)
//     {

//         System.Console.Write($"{element} ");
        
//     }

//     System.Console.WriteLine();
    
// }

// foreach (Fraction[] array in problem_FractionArray2D)
// {

//     foreach (Fraction element in array)
//     {

//         System.Console.Write($"{element} ");
        
//     }

//     System.Console.WriteLine();
    
// }

// foreach (Fraction[] array in destination_FractionArray2D)
// {

//     foreach (Fraction element in array)
//     {

//         System.Console.Write($"{element} ");
        
//     }

//     System.Console.WriteLine();
    
// }

using Fractions;

Fraction[][]augmented_FractionArray2D = [[0,0,1,0,0],[new Fraction(1,4),new Fraction(1,4),new Fraction(1,4),new Fraction(1,4),new Fraction(1,4)],[0,0,new Fraction(1,2),new Fraction(1,2),1],[1,0,0,0,1]];

foreach (Fraction[] row in augmented_FractionArray2D)
{

    foreach (Fraction element in row)
    {

        System.Console.Write($"{element} ");
        
    }

    System.Console.WriteLine();
    
}

System.Console.WriteLine("sorting");

augmented_FractionArray2D = Sort_Function(augmented_FractionArray2D);

System.Console.WriteLine("sorting done");

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

foreach (Fraction[] row in augmented_FractionArray2D)
{

    foreach (Fraction element in row)
    {

        System.Console.Write($"{element} ");
        
    }

    System.Console.WriteLine();
    
}

System.Console.WriteLine();

static Fraction[][] Sort_Function(Fraction[][]augmented_FractionArray2D)
{    

    int[] sorted_IntArray2D = new int[augmented_FractionArray2D.Length];

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

                List<Fraction> column_FractionList = [];

                for (int column_Int = 0; column_Int < augmented_FractionArray2D.Length; column_Int++)
                {

                    column_FractionList.Add(augmented_FractionArray2D[column_Int][check_Int]);
                    
                }

                int[] swapTable_FractionArray2D = CheckOptions_Function(column_FractionList, check_Int);

                swapTable_FractionArray2D[check_Int] = 0;
                
                for (int option_Int = 0; option_Int < augmented_FractionArray2D.Length; option_Int++)
                {

                    if(swapTable_FractionArray2D[option_Int]==1)
                    {

                        if(augmented_FractionArray2D[check_Int][option_Int] == 0)
                        {

                            swapTable_FractionArray2D[option_Int] = 0;
                            
                        }

                    }

                }

                for (int option_Int = 0; option_Int < augmented_FractionArray2D.Length; option_Int++)
                {

                    if(swapTable_FractionArray2D[option_Int]==1)
                    {

                        if(initialize_Bool)
                        {

                            initialize_Bool = false;

                            index_Int = option_Int;

                        }else
                        if(augmented_FractionArray2D[check_Int][index_Int]>augmented_FractionArray2D[check_Int][option_Int])
                            index_Int = option_Int;
                        

                    }

                }

                Fraction[] temp_FractionArray2D = augmented_FractionArray2D[index_Int];

                augmented_FractionArray2D[check_Int] = augmented_FractionArray2D[index_Int];

                augmented_FractionArray2D[index_Int] = temp_FractionArray2D;

                sorted_IntArray2D[check_Int] = 1;

                break;
            
            }

        }else
        {

            for (int row_Int = 0; row_Int < augmented_FractionArray2D.Length; row_Int++)
            {

                if(sorted_IntArray2D[row_Int]==0)
                {                   
            
                    int index_Int = row_Int;

                    bool initialize_Bool = true;

                    List<Fraction> column_FractionList = [];

                    for (int column_Int = 0; column_Int < augmented_FractionArray2D.Length; column_Int++)
                    {

                        column_FractionList.Add(augmented_FractionArray2D[column_Int][0]);
                            
                    }

                    int[] swapTable_FractionArray2D = CheckOptions_Function(column_FractionList, row_Int);

                    for (int option_Int = 0; option_Int < augmented_FractionArray2D.Length; option_Int++)
                    {

                        if(swapTable_FractionArray2D[option_Int]==1)
                        {

                            if(augmented_FractionArray2D[row_Int][option_Int] == 0 | sorted_IntArray2D[option_Int]==1 |
                                augmented_FractionArray2D[row_Int][option_Int] < augmented_FractionArray2D[option_Int][row_Int])
                            {

                                swapTable_FractionArray2D[option_Int] = 0;
                                
                            }

                        }

                    }
                    
                    for (int option_Int = 0; option_Int < augmented_FractionArray2D.Length; option_Int++)
                    {

                        if(swapTable_FractionArray2D[option_Int]==1)
                        {

                            if(initialize_Bool)
                            {

                                initialize_Bool = false;

                                index_Int = option_Int;

                            }else
                            if(augmented_FractionArray2D[row_Int][index_Int]>augmented_FractionArray2D[row_Int][option_Int])
                                index_Int = option_Int;
                            

                        }

                    }

                    if(index_Int!=row_Int)
                    {

                        Fraction[] temp_FractionArray2D = augmented_FractionArray2D[index_Int];

                        augmented_FractionArray2D[row_Int] = augmented_FractionArray2D[index_Int];

                        augmented_FractionArray2D[index_Int] = temp_FractionArray2D;

                        sorted_IntArray2D[row_Int] = 1;

                    }

                    break;

                }
                
            }

        }

    }

    return augmented_FractionArray2D;

}

static int[] CheckOptions_Function(List<Fraction> column_FractionList,int mainElementIndex_Int)
{

    int[] options_IntArray = new int[column_FractionList.Count];

    for (int column_Int = 0; column_Int < column_FractionList.Count; column_Int++)
    {

        if(column_FractionList[column_Int]!=0)
        {

            if(column_FractionList[mainElementIndex_Int]==0 | column_FractionList[mainElementIndex_Int].Abs()>column_FractionList[column_Int].Abs())
                options_IntArray[column_Int] = 1;

        }
        
    }

    options_IntArray[mainElementIndex_Int] = 1;

    return options_IntArray;

}





static void Show3_Function(int[]availableRows_IntArray2D)
{

    int arrayLength_Int = availableRows_IntArray2D.Length;

    foreach(Fraction element in availableRows_IntArray2D)
    {

        System.Console.Write($"{element} ");

        System.Console.WriteLine();
        
    }

}

static void Show2_Function(Fraction[][]availableRows_IntArray2D)
{

    foreach(Fraction[] row in availableRows_IntArray2D)
    {

        foreach (Fraction element in row)
        {

            System.Console.Write($"{element} ");
            
        }

        System.Console.WriteLine();
        
    }

}

static void Show_Function(int[][]availableRows_IntArray2D)
{

    foreach (int[] row in availableRows_IntArray2D)
    {

        foreach (int element in row)
        {

            System.Console.Write($"{element} ");
            
        }

        System.Console.WriteLine();
        
    }

}