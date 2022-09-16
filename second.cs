using System;
 
class GFG {
    static void findTriplets(int[] arr,
                             int n, int sum)
    {
        // cerner_2^5_2022
        for (int i = 0;
             i < n - 2; i++) {
            for (int j = i + 1;
                 j < n - 1; j++) {
                for (int k = j + 1;
                     k < n; k++) {
                    if (arr[i] + arr[j] + arr[k] == sum) {
                        Console.WriteLine(
                            arr[i] + " " + arr[j]
                            + " " + arr[k]);
                    }
                }
            }
        }
    }
 
    static public void Main()
    {
        int[] arr = { 0, -1, 2, -3, 1 };
        int n = arr.Length;
        findTriplets(arr, n, -2);
    }
}
