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

augmented_FractionArray2D = Sort_Function(augmented_FractionArray2D);

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

static Fraction[][] Sort_Function(Fraction[][]augmented_FractionArray2D)
{

    int[] usedRows_IntArray = new int[augmented_FractionArray2D.Length];
    
    (int[][] swapTable_IntArray2D,int[] zeroDiagonal_IntArray,int[] numberOfChoices_IntArray) = AssessMatrix_Function(augmented_FractionArray2D);

    (zeroDiagonal_IntArray,numberOfChoices_IntArray,usedRows_IntArray,int bestChoice_Int) = BestRow_Function(zeroDiagonal_IntArray,numberOfChoices_IntArray,usedRows_IntArray);



    return [];

}

static (int[][],int[],int[]) AssessMatrix_Function(Fraction[][] augmented_FractionArray2D)
{

    int[][] swapTable_IntArray2D = new int[augmented_FractionArray2D.Length][];

    int[] zeroDiagonal_IntArray = new int[augmented_FractionArray2D.Length];    

    int[] numberOfChoices_IntArray = new int[swapTable_IntArray2D.Length];

    for (int row_Int = 0; row_Int < augmented_FractionArray2D.Length; row_Int++)
    {

        swapTable_IntArray2D[row_Int] = new int[augmented_FractionArray2D.Length];

    }
    
    for (int row_Int = 0; row_Int < augmented_FractionArray2D.Length; row_Int++)
    {

        numberOfChoices_IntArray[row_Int] = 0;

        for (int nextRow_Int = row_Int+1; nextRow_Int < augmented_FractionArray2D.Length; nextRow_Int++)
        {

            if(augmented_FractionArray2D[nextRow_Int][row_Int] != 0 & augmented_FractionArray2D[row_Int][row_Int]>augmented_FractionArray2D[nextRow_Int][row_Int].Abs())
            {
             
                swapTable_IntArray2D[row_Int][nextRow_Int] = 1;
                
                numberOfChoices_IntArray[row_Int]++;
                
            }else
                swapTable_IntArray2D[row_Int][nextRow_Int] = 0;
            
        }

        if(augmented_FractionArray2D[row_Int][row_Int]==0)
        {

            zeroDiagonal_IntArray[row_Int] = 1;

            for (int previousRow_Int = 0; previousRow_Int < row_Int; previousRow_Int++)
            {

                if(augmented_FractionArray2D[previousRow_Int][row_Int] != 0)
                {
                 
                    swapTable_IntArray2D[row_Int][previousRow_Int] = 1;

                    numberOfChoices_IntArray[row_Int]++;

                }else
                    swapTable_IntArray2D[row_Int][previousRow_Int] = 0;
                
            }

        }
        
    }

    return (swapTable_IntArray2D,zeroDiagonal_IntArray,numberOfChoices_IntArray);

}

static (int[],int[],int[],int) BestRow_Function(int[] zeroDiagonal_IntArray,int[] numberOfChoices_IntArray,int[] usedRows_IntArray)
{

    int compare_Int = numberOfChoices_IntArray.Max();

    int bestChoice_Int = -1;

    if(zeroDiagonal_IntArray.Max()!=0)
        for (int row_Int = 0; row_Int < zeroDiagonal_IntArray.Length; row_Int++)
        {

            if(zeroDiagonal_IntArray[row_Int]==1)
            {

                bestChoice_Int = row_Int;
        
                numberOfChoices_IntArray[bestChoice_Int] = 0;

                usedRows_IntArray[bestChoice_Int] = 1;

                zeroDiagonal_IntArray[bestChoice_Int] = 0;
                
                return (zeroDiagonal_IntArray,numberOfChoices_IntArray,usedRows_IntArray,bestChoice_Int);
                
            }
            
        }

    if(compare_Int>0)
    {

        for (int row_Int = 0; row_Int < numberOfChoices_IntArray.Length; row_Int++)
        {

            if(numberOfChoices_IntArray[row_Int]!=0 & numberOfChoices_IntArray[row_Int]<compare_Int)
            {

                compare_Int = numberOfChoices_IntArray[row_Int];

                bestChoice_Int = row_Int;

            }
            
        }
    
        numberOfChoices_IntArray[bestChoice_Int] = 0;

        usedRows_IntArray[bestChoice_Int] = 1;

        return (zeroDiagonal_IntArray,numberOfChoices_IntArray,usedRows_IntArray,bestChoice_Int);

    }

    for (int row_Int = 0; row_Int < usedRows_IntArray.Length; row_Int++)
    {

        if(usedRows_IntArray[row_Int]==0)
        {

            bestChoice_Int = row_Int;

        }
        
    }

    numberOfChoices_IntArray[bestChoice_Int] = 0;

    usedRows_IntArray[bestChoice_Int] = 1;

    return (zeroDiagonal_IntArray,numberOfChoices_IntArray,usedRows_IntArray,bestChoice_Int);

}

static (int[][],int) BestOption_Function(,int bestChoice_Int)
{

}







static void Show_Function(Fraction[][]availableRows_IntArray2D)
{

    int arrayLength_Int = availableRows_IntArray2D.Length;

    for (int row_Int = 0; row_Int < arrayLength_Int; row_Int++)
    {

        System.Console.Write($"Row {row_Int+1}: ");

        for(int nextRow_Int = 0; nextRow_Int<arrayLength_Int; nextRow_Int++)
        {

            if(availableRows_IntArray2D[row_Int][nextRow_Int] >= 0)
            {

                System.Console.Write($" {availableRows_IntArray2D[row_Int][nextRow_Int]} ");

            }else
            {

                System.Console.Write($"{availableRows_IntArray2D[row_Int][nextRow_Int]} ");

            }

        }

        System.Console.WriteLine();

    }

}