using System.Runtime.InteropServices;

public interface IRead
{
    
    public static (int,string) KeyToLine_Function()
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

    public static (int,int,ConsoleKey) KeyMenu_Function(string menuStatic_String, string[][] menuItems_ArrayString)
    {
        
        ConsoleKeyInfo userKey_ConsoleKeyInfo;

        (int menuPointerRow_Int, int menuPointerColumn_Int) = (1,1);

        ShowMenu_Function(menuItems_ArrayString, menuPointerRow_Int, menuPointerColumn_Int);

        while((userKey_ConsoleKeyInfo = Console.ReadKey()).Key != ConsoleKey.Escape)
        {

            if(userKey_ConsoleKeyInfo.Key == ConsoleKey.Enter)return(menuPointerRow_Int,menuPointerColumn_Int,userKey_ConsoleKeyInfo.Key);      
            
            Console.Clear();

            (menuPointerRow_Int,menuPointerColumn_Int) = Navigation_Function(userKey_ConsoleKeyInfo.Key, menuItems_ArrayString , menuPointerRow_Int , menuPointerColumn_Int );

            ShowMenu_Function(menuItems_ArrayString, menuPointerRow_Int, menuPointerColumn_Int);

        }

        return(-1,-1,ConsoleKey.None);

    } // was fixing navigation***

    public static (int,int) Navigation_Function(ConsoleKey input_ConsoleKey, string[][] menuItems_ArrayString , int menuPointerRow_Int , int menuPointerColumn_Int)
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
            {

                System.Console.WriteLine("Unknown Input, Use The Arrow Keys (navigation), Hit Enter (selecting) or Escape (Abort)");

            }break;

        }

        return (menuPointerRow_Int,menuPointerColumn_Int);

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