using System.Runtime.InteropServices;

public interface IRead
{

    public static string ReadLineMenu_Function(string menuItems_String)
    {

        Console.Clear();

        System.Console.WriteLine(menuItems_String);

        string? userInput_String = Console.ReadLine();

        return userInput_String??="";

    }

    public static (int,string) ReadKeyToReadLine_Function()
    {

        ConsoleKeyInfo key_ConsoleKeyInfo;

        string input_String = "";

        System.Console.WriteLine("Press \"Ctrl\" + \"Enter\" To Finish Writing\nPress");

        while(true)
        {

            if((key_ConsoleKeyInfo = Console.ReadKey(true)).Modifiers == ConsoleModifiers.Control & key_ConsoleKeyInfo.Key == ConsoleKey.Enter)
            {

                return (2,input_String);

            }

            switch (key_ConsoleKeyInfo.Key)
            {

                case ConsoleKey.Enter: 
                {

                    System.Console.WriteLine();

                    if(input_String != "")
                    {

                        return (1,input_String);

                    }else
                    {

                        return (3,input_String);

                    }

                }

                case ConsoleKey.Escape: return (4,input_String);

                default:
                {                          
                
                    input_String += key_ConsoleKeyInfo.KeyChar.ToString();
                
                    Console.Write(key_ConsoleKeyInfo.KeyChar);
                
                }break;

            }

        }
    }

    public static (int,int,ConsoleKey,FileInfo) ReadKeyMenu_Function(string menuStatic_String, string[][] menuItems_ArrayString)
    {
        
        ConsoleKeyInfo userKey_ConsoleKeyInfo;

        (int menuPointerRow_Int, int menuPointerColumn_Int) = (1,1);

        Navigation_Function(ConsoleKey.None, menuItems_ArrayString , menuPointerRow_Int , menuPointerColumn_Int );

        ShowMenu_Function(menuItems_ArrayString, menuPointerRow_Int, menuPointerColumn_Int);

        while((userKey_ConsoleKeyInfo = Console.ReadKey()).Key != ConsoleKey.Escape)
        {

            switch (userKey_ConsoleKeyInfo.Key)
            {

                case ConsoleKey.NumPad0:return (0,0,userKey_ConsoleKeyInfo.Key,new(""));

                case ConsoleKey.NumPad1:return (1,1,userKey_ConsoleKeyInfo.Key,new(""));

                case ConsoleKey.NumPad2:return (2,2,userKey_ConsoleKeyInfo.Key,new(""));

                case ConsoleKey.NumPad3:return (3,3,userKey_ConsoleKeyInfo.Key,new(""));

                case ConsoleKey.NumPad4:return (4,4,userKey_ConsoleKeyInfo.Key,new(""));

                case ConsoleKey.NumPad5:return (5,5,userKey_ConsoleKeyInfo.Key,new(""));

                case ConsoleKey.NumPad6:return (6,6,userKey_ConsoleKeyInfo.Key,new(""));

                case ConsoleKey.NumPad7:return (7,7,userKey_ConsoleKeyInfo.Key,new(""));

                case ConsoleKey.NumPad8:return (8,8,userKey_ConsoleKeyInfo.Key,new(""));

                case ConsoleKey.NumPad9:return (9,9,userKey_ConsoleKeyInfo.Key,new(""));

                case ConsoleKey.Enter:return (menuPointerRow_Int,menuPointerColumn_Int,userKey_ConsoleKeyInfo.Key,new(""));

                default:
                    System.Console.WriteLine("Use The Arrow Keys To Navigate Or Press \"Enter\" / A Numpad Key To Select");
                    break;

            }

            Console.Clear();

            Navigation_Function(userKey_ConsoleKeyInfo.Key, menuItems_ArrayString , menuPointerRow_Int , menuPointerColumn_Int );

            ShowMenu_Function(menuItems_ArrayString, menuPointerRow_Int, menuPointerColumn_Int);

        }

        return(-1,-1,ConsoleKey.None,new(""));

    }

    public static void Navigation_Function(ConsoleKey input_ConsoleKey, string[][] menuItems_ArrayString , int menuPointerRow_Int , int menuPointerColumn_Int)
    {

        switch (input_ConsoleKey)
        {
            case ConsoleKey.UpArrow:
            {

                if(menuPointerRow_Int < 1)
                {

                    break;

                }

                menuPointerRow_Int--;

            }

                break;
            case ConsoleKey.DownArrow:
            {

                if(menuPointerRow_Int > menuItems_ArrayString.GetUpperBound(0))
                {

                    break;

                }

                menuPointerRow_Int++;

                if(menuPointerColumn_Int > menuItems_ArrayString[menuPointerRow_Int].GetUpperBound(0))
                {

                    menuPointerColumn_Int = menuItems_ArrayString[menuPointerRow_Int].GetUpperBound(0);

                }

            }
                break;
            case ConsoleKey.LeftArrow:
            {

                if(menuPointerColumn_Int < 1)
                {

                    break;

                }

                menuPointerColumn_Int--;

            }
                break;
            case ConsoleKey.RightArrow:
            {

                if(menuPointerColumn_Int > menuItems_ArrayString[menuPointerRow_Int].GetUpperBound(0))
                {

                    break;

                }

                menuPointerRow_Int++;

            }
                break;
            default:
                break;
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

                    System.Console.WriteLine($"{menuItems_ArrayString[rowNumber_Int][columnNumber_Int]} <-");

                }else
                {

                    System.Console.WriteLine($"{menuItems_ArrayString[rowNumber_Int][columnNumber_Int]}");

                }

            }

        }

    }
    
}