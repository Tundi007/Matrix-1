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

//         for (int column_Int=0; column_Int < augmented_FractionArray2D[eliminationRow_Int].Length;column_Int++)
//         {

//             augmented_FractionArray2D[eliminationRow_Int][column_Int]-=diagonalRow_FractionArray*augmented_FractionArray2D[row_Int][column_Int];
            
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
    
//     for(int column_Int = 0; column_Int < backup_FractionArray2D[row_Int].Length;column_Int++)
//     {

//         System.Console.Write($"{backup_FractionArray2D[row_Int][column_Int]} ");
        
//     }

//     System.Console.WriteLine();
    
// }

// System.Console.WriteLine("Final Matrix");

// for(int row_Int = 0; row_Int < augmented_FractionArray2D.Length;row_Int++)
// {

//     System.Console.Write($"Row {row_Int}: ");
    
//     for(int column_Int = 0; column_Int < augmented_FractionArray2D[row_Int].Length;column_Int++)
//     {

//         System.Console.Write($"{augmented_FractionArray2D[row_Int][column_Int]} ");
        
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