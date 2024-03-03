namespace Gaussian_Elimination;

public interface DataInput : IRead
{

    public static void FileInput_Function(string menuItems_String, string[][]menuItems_ArrayString)
    {

        (int menuOptions_Int, _, _) = IRead.ReadKeyMenu_Function("How Do You Want To Proceed? (use arrow keys or select on numpad)", [["Enter Code Manually","Enter Address","Return"]]);

        switch (menuOptions_Int)
        {
            case 0:
            {

                System.Console.WriteLine("Press \"Ctrl\" + \"Enter\" To Finish Writing\nPress");

                ConsoleKeyInfo key_ConsoleKeyInfo;
                
                StreamWriter writeToLocalText_StreamWriter = new("local.txt");

                string input_String = "";

                while(true)
                {

                    if((key_ConsoleKeyInfo = Console.ReadKey()).Modifiers == ConsoleModifiers.Control & key_ConsoleKeyInfo.Key == ConsoleKey.Enter)
                    {

                        break;

                    }

                    input_String += key_ConsoleKeyInfo.KeyChar.ToString();

                    writeToLocalText_StreamWriter.WriteLine(key_ConsoleKeyInfo.KeyChar);

                }

                writeToLocalText_StreamWriter.Dispose();

                if(key_ConsoleKeyInfo.Key == ConsoleKey.Escape) Directory.Delete("local.txt");

            }
                break;
            default:
                break;
        }
        
        
    }

    public static void WriteToFile_Function()
    {

    }

    public static void LineInput_Function()
    {

        System.Console.WriteLine("Enter Desired Line:");

        Console.ReadLine();

    }
    
}

public class UserData
{

}