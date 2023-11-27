using DataStructureAndAlgo.Utility;
namespace DataStructureAndAlgo.Problems;

internal class ArraySearch
{
    int[] intArr;
    int len;
    public ArraySearch(int length)
    {
        intArr = new int[length];
        for (int i = 0; i < length; i++)
            intArr[i] = i;
        len = length;
        CommonFuncs.PrintArray(intArr);
    }

    internal bool Find(int v)
    {
        CommonFuncs.PrintArray(intArr);
        Console.WriteLine("Seacrhing for :" + v);
        for (int i = 0;i < intArr.Length;i++)
            if (intArr[i] == v) return true;
        return false;
    }
}
