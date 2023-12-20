namespace DataStructureAndAlgo.Problems;

internal class BinarySearch
{
    public void FindItem(int[] dataArray, int value)
    {
        if(dataArray.Length == 0)
        {
            Console.WriteLine("Empty Array Passed");
            return;
        }

        int start = 0, end = dataArray.Length - 1, mid = 0;
        while (start < end) 
        {
            if (dataArray[start] == value)
            {
                mid = start;
                break;
            }
            if (dataArray[end] == value)
            {
                mid = end;
                break;
            }
                
            mid = (start + end) / 2;
            if (dataArray[mid] == value)
                break;
            else if (dataArray[mid] < value)
                start = mid + 1;
            else
                end = mid;
        }
        Console.WriteLine("Found at pos: " + (mid + 1));
    }
}
