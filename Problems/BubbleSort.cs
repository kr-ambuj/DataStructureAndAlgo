namespace DataStructureAndAlgo.Problems;

internal class BubbleSort
{
    public int SortCount { get; set; }
    public int[] Sort(int[] data)
    {
        SortCount++;
        int swapCount = 0;
        for (int i = 0; i < data.Length; i++)
        {
            if(i > 0 && (data[i] < data[i - 1]))
            {
                swapCount++;
                data[i] = data[i] + data[i - 1];
                data[i - 1] = data[i] - data[i - 1];
                data[i] = data[i] - data[i - 1];
            }            
        }
        if (swapCount > 0)
            return Sort(data);
        else
            return data;
    }
}
