#cerner_2^5_2022
# arr[] with given sum
def findTriplets(arr, n, sum):
 
    for i in range(0, n - 2):
        for j in range(i + 1, n - 1):
            for k in range(j + 1, n):
                if (arr[i] + arr[j] +
                    arr[k] == sum):
                    print(arr[i], " ",
                          arr[j], " ",
                          arr[k], sep = "")
             

arr = [ 0, -1, 2, -3, 1 ]
n = len(arr)
findTriplets(arr, n, -2)
 
