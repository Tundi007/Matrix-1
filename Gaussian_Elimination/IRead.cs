using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
public interface IRead
{
    
    public static string KeyToLine_Function(string exitCode_String)
    {
        
        ConsoleKeyInfo key_ConsoleKeyInfo;

        string input_String = "";

        int stringIndex_Int = 0;

        string menu_String = "Enter Your Text, Paste Via \"Ctrl\" + \"Shift\" + \"V\"";

        if(exitCode_String != "")menu_String += ", \"End\" To Proceed To Next Step";

        menu_String += " And \"Escape\" To Abort Procedure.";

        Console.Clear();

        System.Console.WriteLine(menu_String);

        while(true)
        {           

            key_ConsoleKeyInfo = Console.ReadKey(false); 

            switch (key_ConsoleKeyInfo.Key)
            {

                case ConsoleKey.Enter: Console.Clear(); return input_String;

                case ConsoleKey.End: Console.Clear(); return input_String + exitCode_String;

                case ConsoleKey.Escape: Console.Clear(); return exitCode_String;

                case ConsoleKey.LeftArrow:
                {
                 
                    if(stringIndex_Int < 1)break;

                    stringIndex_Int--;

                    Console.Clear();
                    
                    System.Console.Write(menu_String + "\n" + input_String[..stringIndex_Int] + "_"+ input_String[stringIndex_Int..]);

                }break;

                case ConsoleKey.RightArrow:{
                 
                    if(stringIndex_Int >= input_String.Length)break;

                    stringIndex_Int++;

                    Console.Clear();
                    
                    System.Console.Write(menu_String + "\n" + input_String[..stringIndex_Int] + "_"+ input_String[stringIndex_Int..]);

                }break;

                case ConsoleKey.Delete:
                {                    

                    if(stringIndex_Int >= input_String.Length)break;
                    
                    input_String = input_String.Remove(stringIndex_Int,1);

                    Console.Clear();

                    System.Console.Write(menu_String + "\n" + input_String[..stringIndex_Int] + "_"+ input_String[stringIndex_Int..]);
                
                }break;

                case ConsoleKey.Backspace:
                {

                    if (stringIndex_Int < 1)break;
                        
                    input_String = input_String.Remove(stringIndex_Int-1,1);

                    stringIndex_Int--;
                    
                    Console.Clear();

                    System.Console.Write(menu_String + "\n" + input_String[..stringIndex_Int] + "_"+ input_String[stringIndex_Int..]);
                    
                }break;

                default:
                {
                
                    input_String = input_String[..stringIndex_Int] + key_ConsoleKeyInfo.KeyChar.ToString() + input_String[stringIndex_Int..];

                    stringIndex_Int++;

                    Console.Clear();
                                    
                    System.Console.Write(menu_String + "\n" + input_String[..stringIndex_Int] + "_"+ input_String[stringIndex_Int..]);
                
                }break;

            }

        }

    }

    public static (int,int) KeyMenu_Function(string menuStatic_String, string[][] menuItems_ArrayString)
    {
        
        ConsoleKeyInfo key_ConsoleKeyInfo;

        (int menuPointerRow_Int, int menuPointerColumn_Int, string hint_String) = (1,1,"Use Arrow Keys To Navigate, \"Enter\" To Select, \"Delete\" To Remove An Element, \"E\" To Replace Element With New Value");

        while(true)
        {

            Console.Clear();

            System.Console.WriteLine(menuStatic_String);
            
            ShowMenu_Function(menuItems_ArrayString, menuPointerRow_Int, menuPointerColumn_Int);

            System.Console.WriteLine(hint_String);

            hint_String = "Use Arrow Keys To Navigate, \"Enter\" To Select, \"Delete\" To Remove An Element, \"E\" To Replace Element With New Value";

            switch ((key_ConsoleKeyInfo = Console.ReadKey(false)).Key)
            {

                case ConsoleKey.Enter: Console.Clear(); return (menuPointerRow_Int,menuPointerColumn_Int);

                case ConsoleKey.Escape: Console.Clear(); return (-1,-1);

                case ConsoleKey.LeftArrow:
                {
                 
                    if(menuPointerColumn_Int < 1)break;

                    menuPointerColumn_Int--;

                }break;

                case ConsoleKey.RightArrow:{
                 
                    if(menuPointerColumn_Int >= menuItems_ArrayString[menuPointerRow_Int].Length)break;

                    menuPointerColumn_Int++;

                }break;

                case ConsoleKey.UpArrow:{
                 
                    if(menuPointerRow_Int < 1)break;

                    menuPointerRow_Int--;

                    if(menuItems_ArrayString[menuPointerRow_Int].Length<menuPointerColumn_Int)menuPointerColumn_Int = menuItems_ArrayString[menuPointerRow_Int].Length;

                }break;

                case ConsoleKey.DownArrow:{
                 
                    if(menuPointerRow_Int >= menuItems_ArrayString.Length)break;

                    menuPointerRow_Int++;

                }break;

                case ConsoleKey.Delete:
                {                    

                    menuItems_ArrayString[menuPointerRow_Int][menuPointerColumn_Int] = "_";
                
                }break;

                default:
                {
                    
                    hint_String = "Undefined Input, " + hint_String;
                
                }break;

            }

        }

    }

    public static void ShowMenu_Function(string[][] menuItems_ArrayString, int menuPointerRow_Int, int menuPointerColumn_Int)
    {

        for(int rowNumber_Int = 0 ; rowNumber_Int < menuItems_ArrayString.GetUpperBound(0) ; rowNumber_Int++)
        {

            for(int columnNumber_Int = 0 ; columnNumber_Int < menuItems_ArrayString[rowNumber_Int].GetUpperBound(0) ; columnNumber_Int++)
            {

                if(rowNumber_Int == menuPointerRow_Int && columnNumber_Int == menuPointerColumn_Int)
                {

                    System.Console.Write($"->{menuItems_ArrayString[rowNumber_Int][columnNumber_Int]}<- ");

                }else
                {

                    System.Console.Write($"{menuItems_ArrayString[rowNumber_Int][columnNumber_Int]} ");

                }

            }

            System.Console.WriteLine();

        }

    }
    
}