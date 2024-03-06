using System.Data;
using System.Data.Common;
using Microsoft.VisualBasic.FileIO;

namespace Gaussian_Elimination;

public class Data
{

    private static int numberOfMatrices_Int = 0;

    private static string[][][] data_StringArray2D
    {
     
        set
        {

            data_StringArray2D = value;

        }
     
        get
        {

            return data_StringArray2D;

        }
        
    }

    public static string[][][] publicData_StringArray2D
    {
        
        get
        {

            return data_StringArray2D;

        }
        
    }

    public static string[][] GetData_Function(int matrixNumber_Int)
    {

        if(0 < matrixNumber_Int & matrixNumber_Int < numberOfMatrices_Int) return publicData_StringArray2D[matrixNumber_Int];

        return [["-1"]];

    }

    public static void InitializeData_Function()
    {

        SetData_Function();

    }

    private static void SetData_Function()
    {

        data_StringArray2D[numberOfMatrices_Int] = IFile.GetDataCSV_Function(IFile.CurrentLocalFile_Function());

        numberOfMatrices_Int++;

        // { this is if we need to new with every matrix

        //     string[][][] tempData_StringArray2D=[];

        //     for(int matrix_int = 0; matrix_int<numberOfMatrices_Int ; matrix_int++)
        //     {

        //         tempData_StringArray2D = publicData_StringArray2D;
                
        //     }
        
        // }        

    }
    
}