using DataStructureAndAlgo.Utility;
namespace DataStructureAndAlgo.Problems;

internal class ArrayInsertionAndDeletion
{
    int[] intArray;
    int len;
    public ArrayInsertionAndDeletion(int length)
    {
        intArray = new int[length];
        for (int i = 0; i < length; i++)
            intArray[i] = i;
        len = length;
        CommonFuncs.PrintArray(intArray);
    }

    internal void Insert(int val, int pos)
    {
        Console.WriteLine();
        if (pos == len - 1)
            intArray[pos] = val;
        else if (pos > len - 1)
            Console.WriteLine("Postion to replace the value is larger than the length of Array, no change to array!!");
        else
        {
            for (int i = len - 2; i > pos - 1; i--)
                intArray[i + 1] = intArray[i];
            intArray[pos] = val;
        }

        CommonFuncs.PrintArray(intArray);
    }

    internal void Delete(int pos)
    {
        Console.WriteLine();
        if (pos == len - 1)
            intArray[pos] = 0;
        else if (pos > len - 1)
            Console.WriteLine("Position to delete is larger than the length of array, no chnage to array!!");
        else
        {
            for (int i = pos; i < len - 1; i++)
                intArray[i] = intArray[i + 1];
            intArray[len - 1] = 0;
        }
        CommonFuncs.PrintArray(intArray);
    }        
}
