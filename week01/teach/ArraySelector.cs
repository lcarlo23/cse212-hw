public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int[] compList = new int[select.Length];
        int index = 0;
        int l1Index = 0;
        int l2Index = 0;

        foreach(var num in select)
        {
            if (num == 1)
            {
                compList[index] = list1[l1Index];
                index++;
                l1Index++;
            } else if (num == 2) {
                compList[index] = list2[l2Index];
                index++;
                l2Index++;
            }
        }

        return compList;
    }
}