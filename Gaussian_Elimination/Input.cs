namespace Gaussian_Elimination;

public interface DataInput : IRead
{

    public static void FileInput_Function(string menuItems_String, string[][]menuItems_ArrayString)
    {

        (int menuOptions_Int, _, _) = IRead.ReadKeyMenu_Function("How Do You Want To Proceed?", [[""],[""]]);

        switch (menuOptions_Int)
        {
            case 0:
                break;
            default:
                break;
        }
        
        
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