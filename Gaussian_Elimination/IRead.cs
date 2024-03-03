public interface IRead
{

    public static string ReadLineMenu_Function(string menuItems_String)
    {

        Console.Clear();

        System.Console.WriteLine(menuItems_String);

        string? userInput_String = Console.ReadLine();

        return userInput_String;

    }

    public static (int,int,ConsoleKey) ReadKeyMenu_Function(string menuStatic_String, string[][] menuItems_ArrayString)
    {
        
        ConsoleKeyInfo userKey_ConsoleKeyInfo;

        (int menuPointerRow_Int, int menuPointerColumn_Int) = (1,1);

              

        while((userKey_ConsoleKeyInfo = Console.ReadKey()).Key == (ConsoleKey.DownArrow | ConsoleKey.UpArrow | ConsoleKey.RightArrow | ConsoleKey.LeftArrow))
        {

            Console.Clear();

            Navigation_Function(userKey_ConsoleKeyInfo.Key, menuItems_ArrayString , menuPointerRow_Int , menuPointerColumn_Int );

            ShowMenu_Function(menuItems_ArrayString, menuPointerRow_Int, menuPointerColumn_Int);

        }

        if(userKey_ConsoleKeyInfo.Key == (ConsoleKey.NumPad0 | ConsoleKey.NumPad1 | ConsoleKey.NumPad2 | ConsoleKey.NumPad3 | ConsoleKey.NumPad4 | ConsoleKey.NumPad5 | ConsoleKey.NumPad6 | ConsoleKey.NumPad7 | ConsoleKey.NumPad8 | ConsoleKey.NumPad9))
        {

            return (menuPointerRow_Int,menuPointerColumn_Int,userKey_ConsoleKeyInfo.Key);

        }

        return (menuPointerRow_Int,menuPointerColumn_Int,userKey_ConsoleKeyInfo.Key);

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